public interface IReport
{
  Report GetReportById(int id);
  IEnumerable<Report> GetAllReports();
  void AddReport(Report report);
  void UpdateReport(Report report);
  void DeleteReport(int id);
}
