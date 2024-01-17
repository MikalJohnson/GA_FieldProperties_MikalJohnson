using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldProperties_MikalJohnson
{
    internal class CustomerReview
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be null or empty");
                }
            }

        public string readOnlyName
        {
            get { return _name; }
        }
        public string writeOnlyName
        {
            set { _name = value; }
        }
        public string writtenreview;
        public int rating;
    }
}
