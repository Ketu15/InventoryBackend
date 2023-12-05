
using InventoryProject.Data;
using Microsoft.EntityFrameworkCore;

public class ReportRepository : IReport
{
  private readonly ApplicationDbContext _dbContext; // Replace DbContext with your actual database context

  public ReportRepository(ApplicationDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public Report GetReportById(int id)
  {
    return _dbContext.Reports.FirstOrDefault(r => r.Id == id);
  }

  public IEnumerable<Report> GetAllReports()
  {
    return _dbContext.Reports.ToList();
  }

  public void AddReport(Report report)
  {
    _dbContext.Reports.Add(report);
    _dbContext.SaveChanges();
  }

  public void UpdateReport(Report report)
  {
    var existingReport = _dbContext.Reports.FirstOrDefault(r => r.Id == report.Id);
    if (existingReport != null)
    {
      existingReport.ProductId = report.ProductId;
      existingReport.SoldQuantity = report.SoldQuantity;
      existingReport.TotalSalesAmount = report.TotalSalesAmount;
      // Update other properties as needed
      _dbContext.SaveChanges();
    }
  }

  public void DeleteReport(int id)
  {
    var report = _dbContext.Reports.FirstOrDefault(r => r.Id == id);
    if (report != null)
    {
      _dbContext.Reports.Remove(report);
      _dbContext.SaveChanges();
    }
  }
}
