using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.IRepositories
{
    public interface IResumeRepository
    {
        Resume GetResumeById(int id);

        void DeleteResume(Resume resume);

        void DeleteResume(int id);

        Resume AddOrUpdateResume(Resume resume);

        void Save();
    }
}
