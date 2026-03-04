const primaryUrl = "https://dummy.restapiexample.com/api/v1/employees";
const fallbackUrl = "https://dummyjson.com/users";

function renderEmployees(title, employees) {
  if (typeof document === "undefined") {
    return;
  }

  const output = document.getElementById("output");
  if (!output) {
    return;
  }

  if (!employees || employees.length === 0) {
    output.textContent = "No employees found.";
    return;
  }

  const rows = employees
    .map(
      employee =>
        `<tr><td>${employee.id}</td><td>${employee.firstName}</td><td>${employee.lastName}</td><td>${employee.age}</td><td>${employee.salary}</td></tr>`
    )
    .join("");

  output.innerHTML = `
    <strong>${title}</strong>
    <table border="1" cellpadding="6" cellspacing="0">
      <thead>
        <tr>
          <th>ID</th>
          <th>First Name</th>
          <th>Last Name</th>
          <th>Age</th>
          <th>Salary</th>
        </tr>
      </thead>
      <tbody>${rows}</tbody>
    </table>
  `;
}

function splitName(fullName) {
  const parts = String(fullName || "").trim().split(/\s+/);
  const firstName = parts[0] || "";
  const lastName = parts.slice(1).join(" ") || "-";
  return { firstName, lastName };
}

function normalizePrimaryEmployees(data) {
  if (!Array.isArray(data?.data)) {
    return [];
  }

  return data.data.map(item => {
    const { firstName, lastName } = splitName(item.employee_name);
    return {
      id: item.id,
      firstName,
      lastName,
      age: item.employee_age ?? "-",
      salary: item.employee_salary ?? "-"
    };
  });
}

function normalizeFallbackEmployees(data) {
  if (!Array.isArray(data?.users)) {
    return [];
  }

  return data.users.map(item => ({
    id: item.id,
    firstName: item.firstName ?? "-",
    lastName: item.lastName ?? "-",
    age: item.age ?? "-",
    salary: item.company?.title ?? "-"
  }));
}

async function fetchJson(url) {
  const response = await fetch(url, {
    headers: {
      Accept: "application/json"
    }
  });

  const contentType = response.headers.get("content-type") || "";
  if (!response.ok) {
    throw new Error(`Request failed (${response.status}) for ${url}`);
  }

  if (!contentType.includes("application/json")) {
    const text = await response.text();
    throw new Error(`Non-JSON response from ${url}: ${text.slice(0, 80)}...`);
  }

  return response.json();
}

async function run() {
  try {
    const data = await fetchJson(primaryUrl);
    console.log("Employee Data (primary API):");
    const employees = normalizePrimaryEmployees(data);
    console.table(employees);
    renderEmployees("Employee Data (primary API)", employees);
  } catch (primaryError) {
    console.warn("Primary API failed:", primaryError.message);
    const data = await fetchJson(fallbackUrl);
    console.log("Employee Data (fallback API):");
    const employees = normalizeFallbackEmployees(data);
    console.table(employees);
    renderEmployees("Employee Data (fallback API)", employees);
  }
}

run().catch(error => {
  console.error("Error fetching data:", error.message);
  if (typeof document !== "undefined") {
    const output = document.getElementById("output");
    if (output) {
      output.textContent = `Error fetching data: ${error.message}`;
    }
  }
});