using DentalOfficeSchedulingApp.Models;
using DentalOfficeSchedulingApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

public partial class UpdateCustomer : Form
{
    private int _selectedCustomerId;
    private bool _loadingCustomers;

    public UpdateCustomer()
    {
        InitializeComponent();
        LoadCustomerList();
        ResetForm();
    }

    private void LoadCustomerList()
    {
        _loadingCustomers = true;
        using var context = new SchedulingContext();

        var customers = context.Customers
            .AsNoTracking()
            .OrderBy(c => c.CustomerName)
            .Select(c => new
            {
                c.CustomerId,
                Display = c.CustomerName + " --ID: " + c.CustomerId
            })
            .ToList();

        SelectCombo.DisplayMember = "Display";
        SelectCombo.ValueMember = "CustomerId";
        SelectCombo.DataSource = customers;
        SelectCombo.SelectedIndex = -1;
        SelectCombo.Text = "--Select--";
        _loadingCustomers = false;
    }

    private void ResetForm()
    {
        _selectedCustomerId = 0;
        NameTxt.Clear();
        AddressTxt.Clear();
        CityTxt.Clear();
        ZipCodeTxt.Clear();
        CountryTxt.Clear();
        PhoneTxt.Clear();
        YesRadio.Checked = false;
        NoRadio.Checked = false;
        NameTxt.Enabled = false;
        AddressTxt.Enabled = false;
        CityTxt.Enabled = false;
        ZipCodeTxt.Enabled = false;
        CountryTxt.Enabled = false;
        PhoneTxt.Enabled = false;
        YesRadio.Enabled = false;
        NoRadio.Enabled = false;
        UpdateBtn.Enabled = false;
    }

    private void SelectCombo_SelectedValueChanged(object? sender, EventArgs e)
    {
        if (_loadingCustomers || SelectCombo.SelectedValue is null || SelectCombo.SelectedIndex < 0)
        {
            return;
        }

        if (!int.TryParse(SelectCombo.SelectedValue.ToString(), out int customerId))
        {
            return;
        }

        using var context = new SchedulingContext();

        var customer = context.Customers
            .AsNoTracking()
            .Include(c => c.Address)
                .ThenInclude(a => a.City)
                .ThenInclude(c => c.Country)
            .FirstOrDefault(c => c.CustomerId == customerId);

        if (customer is null)
        {
            MessageBox.Show("Customer could not be found.");
            return;
        }

        _selectedCustomerId = customer.CustomerId;
        NameTxt.Text = customer.CustomerName;
        AddressTxt.Text = customer.Address.Address1;
        CityTxt.Text = customer.Address.City.City1;
        ZipCodeTxt.Text = customer.Address.PostalCode;
        CountryTxt.Text = customer.Address.City.Country.Country1;
        PhoneTxt.Text = customer.Address.Phone;
        YesRadio.Checked = customer.Active == 1;
        NoRadio.Checked = customer.Active != 1;
        EnableFields();
    }

    private void EnableFields()
    {
        NameTxt.Enabled = true;
        AddressTxt.Enabled = true;
        CityTxt.Enabled = true;
        ZipCodeTxt.Enabled = true;
        CountryTxt.Enabled = true;
        PhoneTxt.Enabled = true;
        YesRadio.Enabled = true;
        NoRadio.Enabled = true;
        UpdateBtn.Enabled = true;
    }

    private void UpdateBtn_Click(object? sender, EventArgs e)
    {
        if (_selectedCustomerId == 0)
        {
            MessageBox.Show("Please select a customer.");
            return;
        }

        if (!CheckEmpty())
        {
            MessageBox.Show("You must fill out all information");
            return;
        }

        var confirmation = MessageBox.Show("Are you sure?", "Update Customer", MessageBoxButtons.YesNo);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        using var context = new SchedulingContext();

        var customer = context.Customers
            .Include(c => c.Address)
                .ThenInclude(a => a.City)
                .ThenInclude(c => c.Country)
            .FirstOrDefault(c => c.CustomerId == _selectedCustomerId);

        if (customer is null)
        {
            MessageBox.Show("Customer could not be found.");
            return;
        }

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

        var city = context.Cities.FirstOrDefault(c => c.City1 == cityName && c.CountryId == country.CountryId);

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

        customer.CustomerName = NameTxt.Text.Trim();
        customer.Active = YesRadio.Checked ? (byte)1 : (byte)0;
        customer.LastUpdate = DateTime.Now;
        customer.LastUpdateBy = CurrentUser.UserName;
        customer.Address.Address1 = AddressTxt.Text.Trim();
        customer.Address.CityId = city.CityId;
        customer.Address.PostalCode = ZipCodeTxt.Text.Trim();
        customer.Address.Phone = PhoneTxt.Text.Trim();
        customer.Address.LastUpdate = DateTime.Now;
        customer.Address.LastUpdateBy = CurrentUser.UserName;
        context.SaveChanges();
        MessageBox.Show("Customer updated successfully!");
        Close();
    }

    private void ExitBtn_Click(object? sender, EventArgs e)
    {
        Close();
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
}