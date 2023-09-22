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
    [DataWindow("dw_admin_grid_employees", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_user\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_user.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee.id\"    OUTER2 =\"ots_adeies_employee.id\" )WHERE(    EXP1 =\"ots_adeies_user.employee_id\"   OP =\"is\"    EXP2 =\"null\" ) )")]
    #endregion
    public class Dw_Admin_Grid_Employees
    {
        [DwColumn("ots_adeies_employee", "id")]
        public decimal? Id { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "first_name")]
        public string First_Name { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "last_name")]
        public string Last_Name { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "email")]
        public string Email { get; set; }

        [DwColumn("ots_adeies_employee", "mobile_num")]
        public decimal? Mobile_Num { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "address")]
        public string Address { get; set; }

        [DwColumn("ots_adeies_employee", "address_num")]
        public decimal? Address_Num { get; set; }

        [DwColumn("ots_adeies_user", "employee_id")]
        public decimal? Ots_Adeies_User_Employee_Id { get; set; }

    }

}



