using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StarterCRM.Module.BusinessObjects
{
    [DefaultClassOptions]
   
    public class Company : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        string shippingAddress;
        object propertyName;
        bool shipToBilling;
        string billingAddress;
        string phoneNumber;
        string website;
        string companyName;

        [RuleRequiredField]
        [RuleUniqueValue]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CompanyName
        {
            get => companyName;
            set => SetPropertyValue(nameof(CompanyName), ref companyName, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Website
        {
            get => website;
            set => SetPropertyValue(nameof(Website), ref website, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetPropertyValue(nameof(PhoneNumber), ref phoneNumber, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string BillingAddress
        {
            get => billingAddress;
            set => SetPropertyValue(nameof(BillingAddress), ref billingAddress, value);
        }
        

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ShippingAddress
        {
            get => shippingAddress;
            set => SetPropertyValue(nameof(ShippingAddress), ref shippingAddress, value);
        }
        [ImmediatePostData]
        public bool ShipToBilling

        {
            get => shipToBilling;
            set => SetPropertyValue(nameof(ShipToBilling), ref shipToBilling, value);
        }
        [Association("Company-CompanyContacts")]
        public XPCollection<CompanyContact> CompanyContacts
        {
            get
            {
                return GetCollection<CompanyContact>(nameof(CompanyContacts));
            }
        }
        
       

    }
}