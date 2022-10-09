using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Levels;

namespace Domain.Repositories
{
    public interface ILevelRepository
    {
        public ICollection<Level> GetAll();
    }
}
