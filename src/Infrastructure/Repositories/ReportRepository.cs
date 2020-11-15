using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class ReportRepository : IReportRepository, IRepository<Report>
    {
        private readonly ApplicationContext _context;
        public ReportRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Report> GetAll()
        {
            return _context.Reports;
        }
        public Report Get(int reportId)
        {
            return _context.Reports.SingleOrDefault(c => c.Id == reportId);
        }

        public void Add(Report report)
        {
            _context.Reports.Add(report);
        }

        public void Delete(int reportId)
        {
            _context.Reports.Remove(Get(reportId));
        }

        public void Update(Report report)
        {
            _context.Reports.Update(report);
        }
    }
}
