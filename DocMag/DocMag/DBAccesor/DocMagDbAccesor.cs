using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocMag.DBAccesor {
    public class DocMagDbAccesor : MySqlAccesor {
        public override string ConnectionStr { get { return ConfigurationManager.ConnectionStrings["docmag"].ConnectionString; } }

        public DocMagDbAccesor() : base() {
        }

        public DataTable GetCustomerMaster() {
            return null;
        }

        public bool Test() {
            return true;
        }
    }
}
