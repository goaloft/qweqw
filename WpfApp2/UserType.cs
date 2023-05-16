using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class UserType
    {
        [Key]
        public int idUserType { get; set; }
        private string nameUserType;

        public string NameUserType
        {
            get { return nameUserType; }
            set { nameUserType = value; }
        }

        public UserType() { }

        public UserType(string nameUserType)
        {
            this.nameUserType = nameUserType;
            
        }
    }
}
