using DentalOfficeSchedulingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

public partial class DeleteCustomer : Form
{
    private int _selectedCustomerId;
    private bool _loadingCustomers;

    public DeleteCustomer()
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
        DeleteBtn.Enabled = false;
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
        DeleteBtn.Enabled = true;
    }

    private void DeleteBtn_Click(object? sender, EventArgs e)
    {
        if (_selectedCustomerId == 0)
        {
            MessageBox.Show("Please select a customer.");
            return;
        }

        var confirmation = MessageBox.Show("Are you sure?", "Delete Customer", MessageBoxButtons.YesNo);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        using var context = new SchedulingContext();

        var customer = context.Customers
            .Include(c => c.Appointments)
            .Include(c => c.Address)
            .FirstOrDefault(c => c.CustomerId == _selectedCustomerId);

        if (customer is null)
        {
            MessageBox.Show("Customer could not be found.");
            return;
        }

        if (customer.Appointments.Any())
        {
            var appointmentConfirmation = MessageBox.Show(
                "Deleting customer will remove all appointments, continue?",
                "Delete Customer",
                MessageBoxButtons.YesNo);

            if (appointmentConfirmation != DialogResult.Yes)
            {
                return;
            }

            context.Appointments.RemoveRange(customer.Appointments);
        }

        var address = customer.Address;
        context.Customers.Remove(customer);
        context.SaveChanges();

        if (address is not null)
        {
            context.Addresses.Remove(address);
            context.SaveChanges();
        }

        MessageBox.Show("Customer deleted successfully!");
        Close();
    }

    private void ExitBtn_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void NameTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void AddressTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void CityTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void ZipCodeTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void CountryTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void PhoneTxt_KeyPress(object? sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }
}