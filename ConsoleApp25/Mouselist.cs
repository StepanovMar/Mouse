using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Mouselist1
{
    public class Mouselist
    {
        private List<Mouse> Mouses = new List<Mouse>();

        public List<Mouse> GetAll()
        {
            return Mouses;
        }

        public Mouse GetById(int id)
        {
            return Mouses.FirstOrDefault(c => c.Id == id);
        }

        public void Insert(Mouse Mouse)
        {
            Mouses.Add(Mouse);
        }

        public void Delete(int id)
        {
            Mouse Mouse = GetById(id);
            if (Mouse != null)
            {
                Mouses.Remove(Mouse);
            }
        }

        public void Update(int id, Mouse Mouse)
        {
            Mouse existingMouse = GetById(id);
            if (existingMouse != null)
            {
                existingMouse.Make = Mouse.Make;
                existingMouse.Model = Mouse.Model;
                existingMouse.Year = Mouse.Year;
                existingMouse.Color = Mouse.Color;
            }
        }

        public List<Mouse> Find(Predicate<Mouse> predicate)
        {
            return Mouses.FindAll(predicate);
        }
    }
}