using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly RestaurantContext context;

        public BranchRepository()
        {
            context = new RestaurantContext();
        }

        public List<Branch> GetAll(string includes = "")
        {
            IQueryable<Branch> query = context.Branches;

            if (!string.IsNullOrEmpty(includes))
            {
                if (includes.Contains("Staff"))
                {
                    query = query.Include(b => b.Staff);
                }
                if (includes.Contains("Tables"))
                {
                    query = query.Include(b => b.Tables);
                }
                if (includes.Contains("Orders"))
                {
                    query = query.Include(b => b.Orders);
                }
            }

            return query.ToList();
        }

        public Branch GetById(int id)
        {
            return context.Branches.FirstOrDefault(b => b.BranchID == id);
        }

        public void Add(Branch obj)
        {
            context.Branches.Add(obj);
        }

        public void Update(Branch obj)
        {
            context.Branches.Update(obj);
        }

        public void Delete(int id)
        {
            var branch = GetById(id);
            if (branch != null)
            {
                context.Branches.Remove(branch);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}