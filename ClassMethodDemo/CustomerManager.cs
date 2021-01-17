using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Get(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla listelendi :\n" + "Id : " + customer.Id + "\n" + "Ad : " +
                customer.FirstName + "\n" + "Soyad : " + customer.LastName + "\n" + "Şehir : " + customer.City + "\n" +
                "Yaş : " + customer.Age + "\n" + "Hesap Bakiyesi : " + customer.AccountBalance + "$");
        }
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla eklendi :\n" + "Id : " + customer.Id + "\n" + "Ad : " + 
                customer.FirstName + "\n" + "Soyad : " + customer.LastName + "\n" + "Şehir : " + customer.City + "\n" + 
                "Yaş : " + customer.Age + "\n" + "Hesap Bakiyesi : " + customer.AccountBalance + "$");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla güncellendi :\n" + "Id : " + customer.Id + "\n" + "Ad : " +
                customer.FirstName + "\n" + "Soyad : " + customer.LastName + "\n" + "Şehir : " + customer.City + "\n" +
                "Yaş : " + customer.Age + "\n" + "Hesap Bakiyesi : " + customer.AccountBalance + "$");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla silindi :\n" + "Id : " + customer.Id + "\n" + "Ad : " +
                customer.FirstName + "\n" + "Soyad : " + customer.LastName + "\n" + "Şehir : " + customer.City + "\n" +
                "Yaş : " + customer.Age + "\n" + "Hesap Bakiyesi : " + customer.AccountBalance + "$");
        }
    }
}
