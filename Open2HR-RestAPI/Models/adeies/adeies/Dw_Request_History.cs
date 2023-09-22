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
    [DataWindow("dw_request_history", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_leave_request\" )  TABLE(NAME=\"ots_adeies_leave_category\" )  TABLE(NAME=\"ots_adeies_status\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_leave_request.leave_category_id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_category.id\" )    JOIN (LEFT=\"ots_adeies_leave_request.status_id\"    OP =\"=\"RIGHT=\"ots_adeies_status.id\" )WHERE(    EXP1 =\"ots_adeies_leave_request.employee_id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    public class Dw_Request_History
    {
        [DwColumn("ots_adeies_leave_request", "employee_id")]
        public decimal? Employee_Id { get; set; }

        [DwColumn("ots_adeies_leave_request", "leave_category_id")]
        public decimal? Leave_Category_Id { get; set; }

        [DwColumn("ots_adeies_leave_request", "duration")]
        public decimal? Duration { get; set; }

        [DwColumn("ots_adeies_leave_request", "status_id")]
        public decimal? Status_Id { get; set; }

        [DwColumn("ots_adeies_leave_request", "id")]
        public decimal Id { get; set; }

        [DwColumn("ots_adeies_leave_category", "title")]
        public string Ots_Adeies_Leave_Category_Title { get; set; }

        [DwColumn("ots_adeies_status", "state")]
        public string Ots_Adeies_Status_State { get; set; }

        [DwColumn("ots_adeies_leave_request", "sumbit_date", TypeName = "datetime")]
        public DateTime? Ots_Adeies_Leave_Request_Sumbit_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "end_date", TypeName = "datetime")]
        public DateTime? Ots_Adeies_Leave_Request_End_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "start_date", TypeName = "datetime")]
        public DateTime? Ots_Adeies_Leave_Request_Start_Date { get; set; }

    }

}



