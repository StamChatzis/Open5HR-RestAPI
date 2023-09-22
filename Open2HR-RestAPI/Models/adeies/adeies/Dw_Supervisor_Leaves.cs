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
    [DataWindow("dw_supervisor_leaves", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" ALIAS=\"ots_adeies_employee_a\" )  TABLE(NAME=\"ots_adeies_employee_supervisor\" )  TABLE(NAME=\"ots_adeies_employee\" ALIAS=\"ots_adeies_employee_b\" )  TABLE(NAME=\"ots_adeies_leave_request\" )  TABLE(NAME=\"ots_adeies_status\" )  TABLE(NAME=\"ots_adeies_leave_category\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_employee_a.id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_supervisor.supervisor_id\" )    JOIN (LEFT=\"ots_adeies_employee_b.id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_supervisor.employee_id\" )    JOIN (LEFT=\"ots_adeies_status.id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_request.status_id\" )    JOIN (LEFT=\"ots_adeies_leave_request.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee_b.id\" )    JOIN (LEFT=\"ots_adeies_leave_category.id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_request.leave_category_id\" )WHERE(    EXP1 =\"ots_adeies_employee_a.id\"   OP =\"=\"    EXP2 =\":an_ID\" ) ) ARG(NAME = \"an_ID\" TYPE = number)")]
    #endregion
    [DwParameter("an_ID", typeof(double?))]
    public class Dw_Supervisor_Leaves
    {
        [StringLength(20)]
        [DwColumn("ots_adeies_employee_b", "first_name")]
        public string Ots_Adeies_Employee_First_Name { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee_b", "last_name")]
        public string Ots_Adeies_Employee_Last_Name { get; set; }

        [DwColumn("ots_adeies_leave_request", "duration")]
        public decimal? Ots_Adeies_Leave_Request_Duration { get; set; }

        [DwColumn("ots_adeies_status", "state")]
        public string Ots_Adeies_Status_State { get; set; }

        [DwColumn("ots_adeies_leave_request", "id")]
        public decimal Ots_Adeies_Leave_Request_Id { get; set; }

        [DwColumn("ots_adeies_leave_request", "status_id")]
        public decimal? Ots_Adeies_Leave_Request_Status_Id { get; set; }

        [DwColumn("ots_adeies_leave_request", "sumbit_date", TypeName = "datetime")]
        public DateTime? Ots_Adeies_Leave_Request_Sumbit_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "start_date", TypeName = "datetime")]
        public DateTime? Ots_Adeies_Leave_Request_Start_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "end_date", TypeName = "datetime")]
        public DateTime? Ots_Adeies_Leave_Request_End_Date { get; set; }

        [DwColumn("ots_adeies_employee_b", "id")]
        public decimal Ots_Adeies_Employee_Id { get; set; }

        [DwColumn("ots_adeies_leave_request", "leave_category_id")]
        public decimal? Ots_Adeies_Leave_Request_Leave_Category_Id { get; set; }

        [DwColumn("ots_adeies_leave_category", "title")]
        public string Ots_Adeies_Leave_Category_Title { get; set; }

    }

}



