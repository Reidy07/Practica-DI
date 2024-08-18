using System;


namespace Practica_DI
{
         public class CustomerRepository
        {
            public void SaveCustomer(string name)
            {
            
            }
        }
        public class CustomerService
        {
            private CustomerRepository _repository;

            public CustomerService()
            {
                _repository = new CustomerRepository();
            }

            public void AddCustomer(string name)
            {
                _repository.SaveCustomer(name);
            }
        }    
}
