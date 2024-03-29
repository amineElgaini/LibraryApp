﻿using LibraryDataAccessLayer;
using System;
using System.Data;
using System.Dynamic;
using System.Net;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryBusinessLayer
{
    public class clsUsers
    {
        enum Mode { add, edit };
        Mode mode;

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string LibraryCardNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }

        public static DataTable FindUsersByName(string value)
        {
            return UsersData.FindUsersByName(value);
        }

        public static DataTable FindUsersById(int value)
        {
            return UsersData.FindUsersById(value);
        }

        public clsUsers(int id, string Name, string Email, DateTime BirthDate, string LibraryCardNumber, string Image)
        {
            this.UserId = id;
            this.Name = Name;
            this.Email = Email;
            this.BirthDate = BirthDate;
            this.LibraryCardNumber = LibraryCardNumber;
            this.Image = Image;
            mode = Mode.edit;
        }

        public static clsUsers FindUserById(int id)
        {
            string Name = "";
            string Email = "";
            DateTime BirthDate = DateTime.Now;
            string LibraryCardNumber = "";
            string Image = "";

            if (UsersData.GetUserInfoByID(id, ref Name, ref Email, ref BirthDate, ref LibraryCardNumber, ref Image))
            {
                return new clsUsers(id, Name, Email, BirthDate, LibraryCardNumber, Image);
            }

            return null;
        }

        public clsUsers()
        {
            UserId = -1;
            Name = "";
            Email = "";
            LibraryCardNumber = "";
            Image = "";
        }

        public static DataTable GetAllUsers()
        {
            return UsersData.GetAllUsers();
        }

        private bool _addUser(string Name, string Email, string LibraryCardNumber, string Image, DateTime BirthDate)
        {
            this.UserId = UsersData.AddUser(Name, Email, LibraryCardNumber, Image, BirthDate);
            return (this.UserId > -1);
        }

        public static clsUsers GetUserByID(int id)
        {
            string Name = "";
            string Email = "";
            string LibraryCardNumber = "";
            string Image = "";
            DateTime BirthDate = DateTime.Now;

            if (UsersData.GetUserInfoByID(id, ref  Name, ref Email, ref BirthDate,
            ref LibraryCardNumber, ref Image))
                return new clsUsers(id, Name, Email, BirthDate, LibraryCardNumber, Image);
            else
                    return null;
        }

        public static bool DeleteUser(int id)
        {
            return UsersData.DeleteUser(id);
        }

        public bool Save()
        {
            switch (mode)
            {

                case Mode.add:
                    if (_addUser(Name, Email, LibraryCardNumber, Image, BirthDate))
                    {
                        mode = Mode.edit; // change mode after adding the user
                        return true;
                    }
                    break;

                case Mode.edit:
                    if (UsersData.UpdateUser(UserId, Name, LibraryCardNumber, Email, Image, BirthDate))
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
