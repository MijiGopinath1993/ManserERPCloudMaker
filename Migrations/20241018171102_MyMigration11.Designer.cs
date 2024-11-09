﻿// <auto-generated />
using System;
using ERPCloudMaker.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERPCloudMaker.Migrations
{
    [DbContext(typeof(CloudDBContext))]
    [Migration("20241018171102_MyMigration11")]
    partial class MyMigration11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ERPCloudMaker.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Accperiodfrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Accperiodto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminUsername")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adminpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaseCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BookPeriodfrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("BookPeriodto")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompAccNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompBankname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Companyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Confpassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currencysymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateFormat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DecialPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Decimalsymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaxNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagefolderpath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemSizeColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VATNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("ERPCloudMaker.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aadharnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Accounttype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allowcostcentre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allowsendemail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allowsendsms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConperEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConperTelnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactpersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customergroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Defaultdiscount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faxnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Iscomposition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postalcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pricelevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telnumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressline2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("addressline3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("creditlimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("monthlybudget")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("payterms")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ERPCloudMaker.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Basicsalary")
                        .HasColumnType("float");

                    b.Property<string>("Contracttype")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CostCat")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime?>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateofJoining")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Designation")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime?>("DisconnectDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Education")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("EmpCity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmpID")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmpName")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("EmpPersonalID")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Empaddress")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Empcontactno")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PerCity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Peraddress")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Percontactno1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Percontactno2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Peremailid")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("RefAddress")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("RefCity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RefContactNo1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RefContactNo2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RefEmailid")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("RefName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RefNotes")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SalaryType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TeamName")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("VisaFrom")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("bankacno")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("bankcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("bankifsccode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("bankmicrcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("contractexpirydate")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailid")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("empbankacno")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("empbankbranch")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("empbankname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("rateperhour")
                        .HasColumnType("float");

                    b.Property<string>("workingfor")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ERPCloudMaker.Models.InvoiceNumberSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Allowduplicateinvno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invnumberingmethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Invnumberstart")
                        .HasColumnType("int");

                    b.Property<string>("Invoicepostfix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoiceprefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxNoofdigits")
                        .HasColumnType("int");

                    b.Property<string>("VoucherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("printaftersave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("printbarcodeaftersave")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InvoiceNumberSettings");
                });

            modelBuilder.Entity("ERPCloudMaker.Models.Permisions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Createdon")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pagecode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permisionpages")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permisions");
                });

            modelBuilder.Entity("ERPCloudMaker.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CounterID")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLogin")
                        .HasColumnType("bit");

                    b.Property<string>("LocationName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LoginSystemName")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime?>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LogoutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SQLUserID")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("SQLpwd")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StoreName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserDepartment")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserEmailId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("UserPassword")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserPasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSecurityA1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserSecurityA2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserSecurityQ1")
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("UserSecurityQ2")
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<int?>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ERPCloudMaker.Models.VoucherNames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VoucherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VoucherNames");
                });
#pragma warning restore 612, 618
        }
    }
}
