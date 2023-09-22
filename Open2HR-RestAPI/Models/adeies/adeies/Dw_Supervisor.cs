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
    [DataWindow("dw_supervisor", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_employee_supervisor\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_employee.id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_supervisor.supervisor_id\" )WHERE(    EXP1 =\"ots_adeies_employee.user_id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    public class Dw_Supervisor
    {
        [DwColumn("ots_adeies_employee", "id")]
        public decimal Ots_Adeies_Employee_Id { get; set; }

        [DwColumn("ots_adeies_employee", "user_id")]
        public decimal? Ots_Adeies_Employee_User_Id { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "first_name")]
        public string Ots_Adeies_Employee_First_Name { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "last_name")]
        public string Ots_Adeies_Employee_Last_Name { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "email")]
        public string Ots_Adeies_Employee_Email { get; set; }

        [DwColumn("ots_adeies_employee", "mobile_num")]
        public decimal? Ots_Adeies_Employee_Mobile_Num { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "address")]
        public string Ots_Adeies_Employee_Address { get; set; }

        [DwColumn("ots_adeies_employee", "address_num")]
        public decimal? Ots_Adeies_Employee_Address_Num { get; set; }

        [DwColumn("ots_adeies_employee_supervisor", "employee_id")]
        public decimal? Ots_Adeies_Employee_Supervisor_Employee_Id { get; set; }

    }

}



