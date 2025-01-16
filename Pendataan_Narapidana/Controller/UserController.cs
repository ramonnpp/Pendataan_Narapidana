using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pendataan_Narapidana.Model.Entity;
using Pendataan_Narapidana.Model.Context;
using Pendataan_Narapidana.Model.Repository;


namespace Pendataan_Narapidana.Controller
{
    public class UserController
    {
        private UserRepository _repository;

        public UserController()
        {
            _repository = new UserRepository();
        }

        public bool Login(string username, string password)
        {
            return _repository.ValidateUser(username, password);
        }
    }
}
