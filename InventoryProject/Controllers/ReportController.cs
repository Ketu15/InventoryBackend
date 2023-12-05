using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReportController : ControllerBase
  {
    private readonly IReport _reportRepository;

    public ReportController(IReport reportRepository)
    {
      _reportRepository = reportRepository;
    }

    [HttpGet("{id}")]
    public IActionResult GetReportById(int id)
    {
      var report = _reportRepository.GetReportById(id);
      if (report == null)
      {
        return NotFound();
      }

      return Ok(report);
    }

    [HttpGet]
    public IActionResult GetAllReports()
    {
      var reports = _reportRepository.GetAllReports();
      return Ok(reports);
    }

    [HttpPost]
    public IActionResult AddReport([FromBody] Report report)
    {
      _reportRepository.AddReport(report);
      return CreatedAtAction(nameof(GetReportById), new { id = report.Id }, report);
    }

    [HttpPut]
    public IActionResult UpdateReport([FromBody] Report report)
    {
      _reportRepository.UpdateReport(report);
      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteReport(int id)
    {
      _reportRepository.DeleteReport(id);
      return NoContent();
    }
  }
}
