import { useEffect, useState } from "react";
import axios from "axios";
import { Bar, Pie } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  BarElement,
  ArcElement,
  Title,
  Tooltip,
  Legend
} from "chart.js";

ChartJS.register(CategoryScale, LinearScale, BarElement, ArcElement, Title, Tooltip, Legend);

const styles = `
  @import url('https://fonts.googleapis.com/css2?family=Syne:wght@400;600;700;800&family=JetBrains+Mono:wght@300;400;500&display=swap');

  *, *::before, *::after { box-sizing: border-box; margin: 0; padding: 0; }

  body {
    background: #080b10;
    font-family: 'Syne', sans-serif;
    color: #e2e8f0;
    min-height: 100vh;
  }

  .dash-root {
    min-height: 100vh;
    background: #080b10;
    background-image:
      radial-gradient(ellipse 80% 40% at 50% -20%, rgba(56,189,248,0.08) 0%, transparent 70%),
      radial-gradient(ellipse 40% 30% at 90% 80%, rgba(99,102,241,0.06) 0%, transparent 60%);
    padding: 32px 40px;
  }

  /* HEADER */
  .header {
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin-bottom: 40px;
    padding-bottom: 24px;
    border-bottom: 1px solid rgba(255,255,255,0.06);
  }
  .header-left { display: flex; align-items: center; gap: 14px; }
  .logo-mark {
    width: 40px; height: 40px;
    background: linear-gradient(135deg, #38bdf8, #818cf8);
    border-radius: 10px;
    display: flex; align-items: center; justify-content: center;
    font-size: 18px; font-weight: 800; color: #fff;
    box-shadow: 0 0 20px rgba(56,189,248,0.3);
  }
  .header h1 {
    font-size: 22px; font-weight: 800; letter-spacing: -0.5px;
    background: linear-gradient(135deg, #f1f5f9 30%, #94a3b8);
    -webkit-background-clip: text; -webkit-text-fill-color: transparent;
  }
  .header-badge {
    font-family: 'JetBrains Mono', monospace;
    font-size: 11px; color: #38bdf8;
    background: rgba(56,189,248,0.1);
    border: 1px solid rgba(56,189,248,0.2);
    padding: 4px 10px; border-radius: 20px;
    letter-spacing: 0.5px;
  }

  /* KPI CARDS */
  .kpi-grid {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
    margin-bottom: 28px;
  }
  .kpi-card {
    background: rgba(255,255,255,0.03);
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 16px;
    padding: 24px 26px;
    position: relative;
    overflow: hidden;
    transition: border-color 0.2s, transform 0.2s;
  }
  .kpi-card:hover { border-color: rgba(56,189,248,0.3); transform: translateY(-2px); }
  .kpi-card::before {
    content: '';
    position: absolute; top: 0; left: 0; right: 0; height: 1px;
    background: linear-gradient(90deg, transparent, rgba(56,189,248,0.4), transparent);
  }
  .kpi-icon {
    width: 36px; height: 36px; border-radius: 10px;
    display: flex; align-items: center; justify-content: center;
    font-size: 16px; margin-bottom: 16px;
  }
  .kpi-icon.green { background: rgba(52,211,153,0.12); }
  .kpi-icon.blue  { background: rgba(56,189,248,0.12); }
  .kpi-icon.purple{ background: rgba(129,140,248,0.12); }
  .kpi-label {
    font-family: 'JetBrains Mono', monospace;
    font-size: 11px; color: #64748b;
    letter-spacing: 1px; text-transform: uppercase;
    margin-bottom: 8px;
  }
  .kpi-value {
    font-size: 30px; font-weight: 800; letter-spacing: -1px;
    background: linear-gradient(135deg, #f1f5f9, #94a3b8);
    -webkit-background-clip: text; -webkit-text-fill-color: transparent;
  }
  .kpi-value.green { background: linear-gradient(135deg, #34d399, #059669); -webkit-background-clip: text; -webkit-text-fill-color: transparent; }
  .kpi-value.red   { background: linear-gradient(135deg, #f87171, #dc2626); -webkit-background-clip: text; -webkit-text-fill-color: transparent; }

  /* CHARTS */
  .charts-main {
    display: grid;
    grid-template-columns: 2fr 1fr;
    gap: 20px;
    margin-bottom: 20px;
  }
  .chart-card {
    background: rgba(255,255,255,0.03);
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 16px;
    padding: 24px;
  }
  .chart-card-full {
    background: rgba(255,255,255,0.03);
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 16px;
    padding: 24px;
    margin-bottom: 28px;
  }
  .chart-title {
    font-size: 13px; font-weight: 700; color: #94a3b8;
    text-transform: uppercase; letter-spacing: 1px;
    margin-bottom: 20px;
    display: flex; align-items: center; gap: 8px;
  }
  .chart-title::before {
    content: '';
    width: 3px; height: 14px;
    background: linear-gradient(180deg, #38bdf8, #818cf8);
    border-radius: 2px;
    display: inline-block;
  }

  /* FORMS SECTION */
  .forms-section {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 20px;
    margin-bottom: 28px;
  }
  .form-card {
    background: rgba(255,255,255,0.03);
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 16px;
    padding: 28px;
  }
  .form-title {
    font-size: 16px; font-weight: 700; color: #f1f5f9;
    margin-bottom: 20px;
    display: flex; align-items: center; gap: 8px;
  }
  .form-grid { display: grid; grid-template-columns: 1fr 1fr; gap: 12px; }
  .form-group { display: flex; flex-direction: column; gap: 6px; }
  .form-group.full { grid-column: 1 / -1; }
  .form-group label {
    font-family: 'JetBrains Mono', monospace;
    font-size: 10px; color: #475569;
    text-transform: uppercase; letter-spacing: 1px;
  }
  .form-input {
    background: rgba(255,255,255,0.04);
    border: 1px solid rgba(255,255,255,0.09);
    border-radius: 10px;
    padding: 10px 14px;
    color: #e2e8f0;
    font-family: 'Syne', sans-serif;
    font-size: 14px;
    outline: none;
    transition: border-color 0.2s, background 0.2s;
    width: 100%;
  }
  .form-input:focus {
    border-color: rgba(56,189,248,0.5);
    background: rgba(56,189,248,0.04);
  }
  .form-input option { background: #141820; }
  .btn {
    margin-top: 16px; width: 100%;
    padding: 12px;
    border: none; border-radius: 10px;
    font-family: 'Syne', sans-serif;
    font-size: 14px; font-weight: 700;
    cursor: pointer; transition: all 0.2s;
    letter-spacing: 0.3px;
  }
  .btn-primary {
    background: linear-gradient(135deg, #38bdf8, #818cf8);
    color: #fff;
    box-shadow: 0 4px 16px rgba(56,189,248,0.2);
  }
  .btn-primary:hover {
    transform: translateY(-1px);
    box-shadow: 0 6px 20px rgba(56,189,248,0.35);
  }
  .btn-green {
    background: linear-gradient(135deg, #34d399, #059669);
    color: #fff;
    box-shadow: 0 4px 16px rgba(52,211,153,0.2);
  }
  .btn-green:hover {
    transform: translateY(-1px);
    box-shadow: 0 6px 20px rgba(52,211,153,0.35);
  }

  /* TABLE */
  .table-card {
    background: rgba(255,255,255,0.03);
    border: 1px solid rgba(255,255,255,0.07);
    border-radius: 16px;
    padding: 24px;
    overflow: hidden;
  }
  .table-wrap { overflow-x: auto; margin-top: 4px; }
  table { width: 100%; border-collapse: collapse; }
  thead tr {
    border-bottom: 1px solid rgba(255,255,255,0.06);
  }
  th {
    font-family: 'JetBrains Mono', monospace;
    font-size: 10px; color: #475569;
    text-transform: uppercase; letter-spacing: 1px;
    padding: 0 16px 12px;
    text-align: left; font-weight: 500;
  }
  td {
    padding: 14px 16px;
    font-size: 14px; color: #94a3b8;
    border-bottom: 1px solid rgba(255,255,255,0.04);
  }
  tbody tr { transition: background 0.15s; }
  tbody tr:hover { background: rgba(255,255,255,0.03); }
  tbody tr:last-child td { border-bottom: none; }
  td.id-cell {
    font-family: 'JetBrains Mono', monospace;
    font-size: 12px; color: #475569;
  }
  td.amount-cell { font-weight: 700; color: #f1f5f9; }
  .badge {
    display: inline-flex; align-items: center; gap: 5px;
    padding: 3px 10px; border-radius: 20px;
    font-size: 11px; font-weight: 600;
    font-family: 'JetBrains Mono', monospace;
  }
  .badge-paid { background: rgba(52,211,153,0.12); color: #34d399; }
  .badge-unpaid { background: rgba(248,113,113,0.12); color: #f87171; }
  .badge-dot { width: 5px; height: 5px; border-radius: 50%; }
  .badge-paid .badge-dot { background: #34d399; }
  .badge-unpaid .badge-dot { background: #f87171; }
`;

const fmt = (n) =>
  new Intl.NumberFormat("en-US", { style: "currency", currency: "USD", maximumFractionDigits: 0 }).format(n);

const chartOpts = (color = "#38bdf8") => ({
  responsive: true,
  plugins: {
    legend: { display: false },
    tooltip: {
      backgroundColor: "rgba(15,20,30,0.95)",
      borderColor: "rgba(56,189,248,0.2)",
      borderWidth: 1,
      titleColor: "#94a3b8",
      bodyColor: "#f1f5f9",
      padding: 10,
      cornerRadius: 8,
    },
  },
  scales: {
    x: { grid: { color: "rgba(255,255,255,0.04)" }, ticks: { color: "#475569", font: { family: "JetBrains Mono", size: 10 } } },
    y: { grid: { color: "rgba(255,255,255,0.04)" }, ticks: { color: "#475569", font: { family: "JetBrains Mono", size: 10 } } },
  },
});

const pieOpts = {
  responsive: true,
  plugins: {
    legend: {
      position: "bottom",
      labels: { color: "#64748b", padding: 16, font: { family: "Syne", size: 12 } },
    },
    tooltip: {
      backgroundColor: "rgba(15,20,30,0.95)",
      borderColor: "rgba(56,189,248,0.2)",
      borderWidth: 1,
      titleColor: "#94a3b8",
      bodyColor: "#f1f5f9",
      padding: 10,
      cornerRadius: 8,
    },
  },
};

function Dashboard() {
  const [invoices, setInvoices] = useState([]);

  const [invoiceForm, setInvoiceForm] = useState({
    customerID: "", invoiceDate: "", dueDate: "",
    totalAmount: "", status: "Unpaid", billingCycleID: 1,
  });

  const [paymentForm, setPaymentForm] = useState({
    invoiceID: "", paymentDate: "", amountPaid: "",
  });

  useEffect(() => { loadInvoices(); }, []);

  const loadInvoices = async () => {
    const res = await axios.get("https://localhost:7108/api/Invoice");
    setInvoices(res.data);
  };

  const handleInvoiceChange = (e) =>
    setInvoiceForm({ ...invoiceForm, [e.target.name]: e.target.value });

  const createInvoice = async () => {
    if (invoiceForm.totalAmount <= 0) { alert("Amount must be greater than 0"); return; }
    await axios.post("https://localhost:7108/api/Invoice", invoiceForm);
    alert("Invoice Created");
    loadInvoices();
  };

  const handlePaymentChange = (e) =>
    setPaymentForm({ ...paymentForm, [e.target.name]: e.target.value });

  const createPayment = async () => {
    if (paymentForm.amountPaid <= 0) { alert("Invalid payment amount"); return; }
    await axios.post("https://localhost:7108/api/Payment", paymentForm);
    alert("Payment Recorded");
    loadInvoices();
  };

  // KPIs
  const totalRevenue = invoices.reduce((s, i) => s + i.totalAmount, 0);
  const outstanding = invoices.filter(i => i.status === "Unpaid").reduce((s, i) => s + i.totalAmount, 0);
  const paidCount = invoices.filter(i => i.status === "Paid").length;
  const unpaidCount = invoices.filter(i => i.status === "Unpaid").length;

  // Charts
  const revenueChart = {
    labels: invoices.map(i => "Inv #" + i.invoiceID),
    datasets: [{ label: "Amount", data: invoices.map(i => i.totalAmount), backgroundColor: "rgba(56,189,248,0.7)", borderRadius: 6, borderSkipped: false }],
  };

  const paymentPie = {
    labels: ["Paid", "Unpaid"],
    datasets: [{ data: [paidCount, unpaidCount], backgroundColor: ["#34d399", "#f87171"], borderWidth: 0, hoverOffset: 6 }],
  };

  const monthlyData = {};
  invoices.forEach(i => {
    const month = new Date(i.invoiceDate).toLocaleString("default", { month: "short" });
    if (!monthlyData[month]) monthlyData[month] = 0;
    monthlyData[month] += i.totalAmount;
  });

  const monthlyChart = {
    labels: Object.keys(monthlyData),
    datasets: [{ label: "Revenue", data: Object.values(monthlyData), backgroundColor: "rgba(129,140,248,0.7)", borderRadius: 6, borderSkipped: false }],
  };

  return (
    <>
      <style>{styles}</style>
      <div className="dash-root">

        {/* HEADER */}
        <div className="header">
          <div className="header-left">
            <div className="logo-mark">F</div>
            <h1>Finance Dashboard</h1>
          </div>
          <span className="header-badge">LIVE · {invoices.length} INVOICES</span>
        </div>

        {/* KPI CARDS */}
        <div className="kpi-grid">
          <div className="kpi-card">
            <div className="kpi-icon green">💰</div>
            <div className="kpi-label">Total Revenue</div>
            <div className="kpi-value green">{fmt(totalRevenue)}</div>
          </div>
          <div className="kpi-card">
            <div className="kpi-icon blue">⏳</div>
            <div className="kpi-label">Outstanding</div>
            <div className="kpi-value red">{fmt(outstanding)}</div>
          </div>
          <div className="kpi-card">
            <div className="kpi-icon purple">📄</div>
            <div className="kpi-label">Total Invoices</div>
            <div className="kpi-value">{invoices.length}</div>
          </div>
        </div>

        {/* MAIN CHARTS */}
        <div className="charts-main">
          <div className="chart-card">
            <div className="chart-title">Revenue by Invoice</div>
            <Bar data={revenueChart} options={chartOpts()} />
          </div>
          <div className="chart-card">
            <div className="chart-title">Payment Status</div>
            <Pie data={paymentPie} options={pieOpts} />
          </div>
        </div>

        {/* MONTHLY CHART */}
        <div className="chart-card-full">
          <div className="chart-title">Monthly Revenue</div>
          <Bar data={monthlyChart} options={chartOpts("#818cf8")} />
        </div>

        {/* FORMS */}
        <div className="forms-section">

          <div className="form-card">
            <div className="form-title">➕ Add Invoice</div>
            <div className="form-grid">
              <div className="form-group">
                <label>Customer ID</label>
                <input className="form-input" name="customerID" placeholder="e.g. 1042" onChange={handleInvoiceChange} />
              </div>
              <div className="form-group">
                <label>Amount</label>
                <input className="form-input" name="totalAmount" placeholder="0.00" onChange={handleInvoiceChange} />
              </div>
              <div className="form-group">
                <label>Invoice Date</label>
                <input className="form-input" type="date" name="invoiceDate" onChange={handleInvoiceChange} />
              </div>
              <div className="form-group">
                <label>Due Date</label>
                <input className="form-input" type="date" name="dueDate" onChange={handleInvoiceChange} />
              </div>
              <div className="form-group full">
                <label>Status</label>
                <select className="form-input" name="status" onChange={handleInvoiceChange}>
                  <option value="Unpaid">Unpaid</option>
                  <option value="Paid">Paid</option>
                </select>
              </div>
            </div>
            <button className="btn btn-primary" onClick={createInvoice}>Create Invoice</button>
          </div>

          <div className="form-card">
            <div className="form-title">💳 Record Payment</div>
            <div className="form-grid">
              <div className="form-group">
                <label>Invoice ID</label>
                <input className="form-input" name="invoiceID" placeholder="e.g. 55" onChange={handlePaymentChange} />
              </div>
              <div className="form-group">
                <label>Amount Paid</label>
                <input className="form-input" name="amountPaid" placeholder="0.00" onChange={handlePaymentChange} />
              </div>
              <div className="form-group full">
                <label>Payment Date</label>
                <input className="form-input" type="date" name="paymentDate" onChange={handlePaymentChange} />
              </div>
            </div>
            <button className="btn btn-green" onClick={createPayment}>Submit Payment</button>
          </div>

        </div>

        {/* TABLE */}
        <div className="table-card">
          <div className="chart-title">All Invoices</div>
          <div className="table-wrap">
            <table>
              <thead>
                <tr>
                  <th>ID</th>
                  <th>Customer</th>
                  <th>Invoice Date</th>
                  <th>Due Date</th>
                  <th>Amount</th>
                  <th>Status</th>
                </tr>
              </thead>
              <tbody>
                {invoices.map(inv => (
                  <tr key={inv.invoiceID}>
                    <td className="id-cell">#{inv.invoiceID}</td>
                    <td>{inv.customerName}</td>
                    <td>{new Date(inv.invoiceDate).toLocaleDateString("en-US", { month: "short", day: "numeric", year: "numeric" })}</td>
                    <td>{new Date(inv.dueDate).toLocaleDateString("en-US", { month: "short", day: "numeric", year: "numeric" })}</td>
                    <td className="amount-cell">{fmt(inv.totalAmount)}</td>
                    <td>
                      <span className={`badge ${inv.status === "Paid" ? "badge-paid" : "badge-unpaid"}`}>
                        <span className="badge-dot" />
                        {inv.status}
                      </span>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>

      </div>
    </>
  );
}

export default Dashboard;
