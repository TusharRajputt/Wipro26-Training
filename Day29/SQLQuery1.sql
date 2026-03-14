DECLARE @Region VARCHAR(50) = 'North'
DECLARE @Priority VARCHAR(20) = 'High'
DECLARE @StartDate DATE = '2025-03-01'
DECLARE @EndDate DATE = '2025-03-20'

SELECT 
TicketID,
Region,
Priority,
SLAStatus,
CreatedDate,
ResolvedDate,
DATEDIFF(DAY, CreatedDate, ResolvedDate) AS ResolutionTime
FROM ServiceTickets
WHERE Region = @Region
AND Priority = @Priority
AND CreatedDate BETWEEN @StartDate AND @EndDate;