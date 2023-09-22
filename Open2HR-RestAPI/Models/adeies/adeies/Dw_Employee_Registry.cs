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
    [DataWindow("dw_employee_registry", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" ALIAS=\"ots_adeies_employee_a\" )  TABLE(NAME=\"ots_adeies_user\" )  TABLE(NAME=\"ots_adeies_employee_supervisor\" )  TABLE(NAME=\"ots_adeies_employee\" ALIAS=\"ots_adeies_employee_b\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_user.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_a.id\"    OUTER2 =\"ots_adeies_employee_a.id\" )    JOIN (LEFT=\"ots_adeies_employee_a.id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_supervisor.employee_id\"    OUTER1 =\"ots_adeies_employee_a.id\" )    JOIN (LEFT=\"ots_adeies_employee_supervisor.supervisor_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_b.id\"    OUTER1 =\"ots_adeies_employee_supervisor.supervisor_id\" ))")]
    #endregion
    [DwTemplate(DataFormat.Xml, "custom_registry", "adeies\\adeies\\dw_employee_registry.tpl.custom_registry.xml")]
    public class Dw_Employee_Registry
    {
        [DwColumn("ots_adeies_employee_a", "id")]
        public decimal? Ots_Adeies_Employee_Id { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee_a", "first_name")]
        public string Ots_Adeies_Employee_First_Name_1 { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee_a", "last_name")]
        public string Ots_Adeies_Employee_Last_Name_1 { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_user", "username")]
        public string Ots_Adeies_User_Username { get; set; }

        [DwColumn("ots_adeies_employee_supervisor", "supervisor_id")]
        public decimal? Ots_Adeies_Employee_Supervisor_Supervisor_Id { get; set; }

        [DwColumn("ots_adeies_employee_b", "first_name")]
        public string Ots_Adeies_Employee_First_Name { get; set; }

        [DwColumn("ots_adeies_employee_b", "last_name")]
        public string Ots_Adeies_Employee_Last_Name { get; set; }

        [DwColumn("ots_adeies_user", "employee_id")]
        public decimal? Ots_Adeies_User_Employee_Id { get; set; }

    }

}



