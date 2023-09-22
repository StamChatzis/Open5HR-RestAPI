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
    [DataWindow("dw_employee_leaves", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_leave_request\" )  TABLE(NAME=\"ots_adeies_status\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_employee.id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_request.id\" )    JOIN (LEFT=\"ots_adeies_status.id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_request.status_id\" )WHERE(    EXP1 =\"ots_adeies_employee.id\"   OP =\"=\"    EXP2 =\"ots_adeies_leave_request.employee_id\" ) )")]
    #endregion
    [DwTemplate(DataFormat.Xml, "dw_employee_leaves", "adeies\\adeies\\dw_employee_leaves.tpl.dw_employee_leaves.xml")]
    public class Dw_Employee_Leaves
    {
        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "first_name")]
        public string First_Name { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_employee", "last_name")]
        public string Last_Name { get; set; }

        [DwColumn("ots_adeies_leave_request", "sumbit_date")]
        public DateTime? Submit_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "start_date")]
        public DateTime? Start_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "end_date")]
        public DateTime? End_Date { get; set; }

        [DwColumn("ots_adeies_leave_request", "duration")]
        public decimal? Duration { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_status", "state")]
        public string Status { get; set; }

    }

}



