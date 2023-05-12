using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BankLibrary;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace pz_29
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        Bank<Account> bank = new Bank<Account>("ЮнитБанк");
        
        private static void OpenAccount(Bank<Account> bank)
        {           
            string input = Interaction.InputBox("Укажите сумму для создания счета:", "Ввод суммы");
            decimal sum = Convert.ToDecimal(input);
            string input2 = Interaction.InputBox("Выберите тип счета: 1. До востребования 2. Депозит");
            AccountType accountType;
            int type = Convert.ToInt32(input2);
            if (type == 2)
                accountType = AccountType.Deposit;
            else
                accountType = AccountType.Ordinary;
            bank.Open(accountType,
            sum,
            AddSumHandler,
            WithdrawSumHandler,
            (o, e) => MessageBox.Show(e.Message),
            CloseAccountHandler,
            OpenAccountHandler);
        }
        private static void Withdraw(Bank<Account> bank)
        {
            string input = Interaction.InputBox("Укажите сумму для вывода счета:", "Ввод суммы");
            decimal sum = Convert.ToDecimal(input);
            string input2 = Interaction.InputBox("Введите id счета:");
            int id = Convert.ToInt32(input2);
            bank.Withdraw(sum, id);
        }
        private static void Put(Bank<Account> bank)
        {
            string input = Interaction.InputBox("Укажите сумму, чтобы положить на счет:", "Ввод суммы");
            decimal sum = Convert.ToDecimal(input);
            string input2 = Interaction.InputBox("Введите Id счета:", "Ввод суммы");
            int id = Convert.ToInt32(input2);
            bank.Put(sum, id);
        }
        private static void CloseAccount(Bank<Account> bank)
        {
            string input = Interaction.InputBox("Введите id счета, который надо закрыть:", "Ввод суммы");
            int id = Convert.ToInt32(input);
            bank.Close(id);
        }

        private static void OpenAccountHandler(object sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private static void AddSumHandler(object sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private static void WithdrawSumHandler(object sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message);
            if (e.Sum > 0)
            MessageBox.Show("Идем тратить деньги");
        }

        private static void CloseAccountHandler(object sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private static void Skip_A_Day(object sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private static void Exit(object sender, AccountEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenAccountHandler(object sender, RoutedEventArgs e)
        {
            OpenAccount(bank);
            bank.CalculatePercentage();
        }

        private void WithdrawSumHandler(object sender, RoutedEventArgs e)
        {
            Withdraw(bank);
            bank.CalculatePercentage();
        }

        private void AddSumHandler(object sender, RoutedEventArgs e)
        {
            Put(bank);
            bank.CalculatePercentage();
        }

        private void CloseAccountHandler(object sender, RoutedEventArgs e)
        {
            CloseAccount(bank);
            bank.CalculatePercentage();
        }

        private void Skip_A_Day(object sender, RoutedEventArgs e)
        {
            bank.CalculatePercentage();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            AccountEventArgs accountEventArgs = new AccountEventArgs("Выход из приложения", 0);
            Exit(sender, accountEventArgs);
            bank.CalculatePercentage();
        }
    }
}


