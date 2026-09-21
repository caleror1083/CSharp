using DentalOfficeSchedulingApp.Models;
using DentalOfficeSchedulingApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

public partial class AddCustomer : Form
{
    public AddCustomer()
    {
        InitializeComponent();
        YesRadio.Checked = true;
    }

    private bool CheckEmpty()
    {
        foreach (Control control in Controls)
        {
            if (control is TextBox textBox &&
                string.IsNullOrWhiteSpace(textBox.Text))
            {
                return false;
            }
        }

        return true;
    }

    private void NameTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void AddressTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void CityTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void ZipCodeTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void CountryTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsLetter(e.KeyChar) &&
            !char.IsWhiteSpace(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void PhoneTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) &&
            !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void AddBtn_Click(object? sender, EventArgs e)
    {
        if (!CheckEmpty())
        {
            MessageBox.Show("You must fill out all information");
            return;
        }

        using var context = new SchedulingContext();
        string countryName = CountryTxt.Text.Trim();
        string cityName = CityTxt.Text.Trim();
        var country = context.Countries.FirstOrDefault(c => c.Country1 == countryName);

        if (country is null)
        {
            country = new Country
            {
                Country1 = countryName,
                CreateDate = DateTime.Now,
                CreatedBy = CurrentUser.UserName,
                LastUpdate = DateTime.Now,
                LastUpdateBy = CurrentUser.UserName
            };

            context.Countries.Add(country);
            context.SaveChanges();
        }

        var city = context.Cities
            .FirstOrDefault(c =>
                c.City1 == cityName &&
                c.CountryId == country.CountryId);

        if (city is null)
        {
            city = new City
            {
                City1 = cityName,
                CountryId = country.CountryId,
                CreateDate = DateTime.Now,
                CreatedBy = CurrentUser.UserName,
                LastUpdate = DateTime.Now,
                LastUpdateBy = CurrentUser.UserName
            };

            context.Cities.Add(city);
            context.SaveChanges();
        }

        var address = new Address
        {
            Address1 = AddressTxt.Text.Trim(),
            Address2 = string.Empty,
            CityId = city.CityId,
            PostalCode = ZipCodeTxt.Text.Trim(),
            Phone = PhoneTxt.Text.Trim(),
            CreateDate = DateTime.Now,
            CreatedBy = CurrentUser.UserName,
            LastUpdate = DateTime.Now,
            LastUpdateBy = CurrentUser.UserName
        };

        context.Addresses.Add(address);
        context.SaveChanges();

        var customer = new Customer
        {
            CustomerName = NameTxt.Text.Trim(),
            AddressId = address.AddressId,
            Active = YesRadio.Checked ? (byte)1 : (byte)0,
            CreateDate = DateTime.Now,
            CreatedBy = CurrentUser.UserName,
            LastUpdate = DateTime.Now,
            LastUpdateBy = CurrentUser.UserName
        };

        context.Customers.Add(customer);
        context.SaveChanges();
        MessageBox.Show("Customer created successfully!");
        Close();
    }

    private void ExitBtn_Click(object? sender, EventArgs e)
    {
        Close();
    }
}