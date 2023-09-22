using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace Open2HRRestAPI.Models 
{
    [DataWindow("dw_hr_employees_wo_users", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_user\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_user.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee.id\"    OUTER2 =\"ots_adeies_employee.id\" )WHERE(    EXP1 =\"ots_adeies_user.employee_id\"   OP =\"is\"    EXP2 =\"null\" ) )")]
    #endregion
    public class Dw_Hr_Employees_Wo_Users
    {
        [DwColumn("ots_adeies_employee", "id")]
        public decimal? Ots_Adeies_Employee_Id { get; set; }

        [DwColumn("ots_adeies_employee", "first_name")]
        public string Ots_Adeies_Employee_First_Name { get; set; }

        [DwColumn("ots_adeies_employee", "last_name")]
        public string Ots_Adeies_Employee_Last_Name { get; set; }

        [DwColumn("ots_adeies_employee", "email")]
        public string Ots_Adeies_Employee_Email { get; set; }

        [DwColumn("ots_adeies_employee", "mobile_num")]
        public decimal? Ots_Adeies_Employee_Mobile_Num { get; set; }

        [DwColumn("ots_adeies_employee", "address")]
        public string Ots_Adeies_Employee_Address { get; set; }

        [DwColumn("ots_adeies_employee", "address_num")]
        public decimal? Ots_Adeies_Employee_Address_Num { get; set; }

        [DwColumn("ots_adeies_employee", "isSupervisor")]
        public int? Ots_Adeies_Employee_Issupervisor { get; set; }

        [DwColumn("ots_adeies_employee", "hire_date")]
        public DateTime? Ots_Adeies_Employee_Hire_Date { get; set; }

    }

}



