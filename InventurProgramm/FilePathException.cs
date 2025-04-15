using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventurProgramm {
    public class FilePathException : Exception {
        public FilePathException() {

        }

        public FilePathException(string message) : base(message) {

        }

        public FilePathException(string message, Exception innerException) : base(message, innerException) {

        }
    }
}
