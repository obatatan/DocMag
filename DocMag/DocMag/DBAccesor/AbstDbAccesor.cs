using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace DocMag.DBAccesor {
    public abstract class AbstDbAccesor : IDbAccesor {
        public abstract string ConnectionStr { get; }

        public DbConnection Con { get; set; }

        public bool Close() {
            try {
                Con.Close();
            } catch {
                return false;
            }
            return true;
        }

        public bool Connect() {
            try {
                Con.Close();
            } catch {
                return false;
            }
            return true;
        }

        public ConnectionState Status() {
            return Con.State;
        }
    }
}
