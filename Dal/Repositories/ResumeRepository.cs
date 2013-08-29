using Model;
using Model.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repositories
{
    public class ResumeRepository : IResumeRepository
    {
        private ResumeContext context;

        public ResumeRepository(ResumeContext context)
        {
            this.context = context;
        }

        public Resume GetResumeById(int id)
        {
            return context.Resumes.SingleOrDefault(r => r.Id == id);
        }

        public void DeleteResume(Resume resume)
        {
            context.Resumes.Remove(resume);
        }

        public void DeleteResume(int id)
        {
            DeleteResume(GetResumeById(id));
        }

        public Model.Resume AddOrUpdateResume(Resume resume)
        {
            if (resume.Id == default(int))
            {
                context.Entry(resume).State = System.Data.EntityState.Modified;
            }
            else
            {
                context.Resumes.Attach(resume);
            }

            return resume;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
