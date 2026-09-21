using DentalOfficeSchedulingApp.Models;
using DentalOfficeSchedulingApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DentalOfficeSchedulingApp;

public partial class Scheduling : Form
{
    public Scheduling()
    {
        InitializeComponent();
        UpdateCalendar();
    }

    private void UpdateCalendar()
    {
        using var context = new SchedulingContext();
        DateTime now = DateTime.Now;
        DateTime startDate;
        DateTime endDate;

        if (WeeklyCalendar.Checked)
        {
            startDate = now.Date.AddDays(-(int)now.DayOfWeek);
            endDate = startDate.AddDays(7);
        }
        else
        {
            startDate = new DateTime(now.Year, now.Month, 1);
            endDate = startDate.AddMonths(1);
        }

        var appointments = context.Appointments
            .AsNoTracking()
            .Where(a =>
                a.UserId == CurrentUser.UserId &&
                a.Start >= startDate &&
                a.Start < endDate)
            .Select(a => new
            {
                id = a.AppointmentId,
                type = a.Type,
                start = a.Start,
                end = a.End,
                customer = a.Customer.CustomerName
            })
            .OrderBy(a => a.start)
            .ToList();

        CalendarDGV.DataSource = appointments;
    }

    private void WeeklyCalendar_CheckedChanged(object? sender, EventArgs e)
    {
        UpdateCalendar();
    }

    private void RefreshBtn_Click(object? sender, EventArgs e)
    {
        UpdateCalendar();
    }

    private void AddCustBtn_Click(object? sender, EventArgs e)
    {
        using var addCustomer = new AddCustomer
        {
            Owner = this
        };

        Hide();
        addCustomer.ShowDialog();
        Show();
    }

    private void UpdateCustBtn_Click(object? sender, EventArgs e)
    {
        using var updateCustomer = new UpdateCustomer
        {
            Owner = this
        };

        Hide();
        updateCustomer.ShowDialog();
        Show();
    }

    private void DeleteCustBtn_Click(object? sender, EventArgs e)
    {
        using var deleteCustomer = new DeleteCustomer
        {
            Owner = this
        };

        Hide();
        deleteCustomer.ShowDialog();
        Show();
    }

    private void AddApptBtn_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Add Appointment will be migrated later.");
    }

    private void UpdateApptBtn_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Update Appointment will be migrated later.");
    }

    private void DeleteApptBtn_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Delete Appointment will be migrated later.");
    }

    private void AppointmentsByCustomer_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Appointments by Customer will be migrated later.");
    }

    private void AppointmentsByConsultant_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Appointments by User will be migrated later.");
    }

    private void ReportAppointmentMonth_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Appointments by Month report will be migrated later.");
    }

    private void ReportAppointmentType_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Appointments by Type report will be migrated later.");
    }

    private void AddUserBtn_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Add User will be migrated later.");
    }

    private void UpdateUserBtn_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Update User will be migrated later.");
    }

    private void DeleteUserBtn_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Delete User will be migrated later.");
    }

    private void Scheduling_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (CurrentUser.IsLoggedIn)
        {
            Log.Logout(CurrentUser.UserName);
            CurrentUser.Clear();
        }
    }
}