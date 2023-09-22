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
    [DataWindow("dw_new_employee_balance", DwStyle.Grid)]
    [Table("ots_adeies_leave_balance")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_leave_balance\" )  TABLE(NAME=\"ots_adeies_leave_category\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_leave_category.id\"    OP =\"=\"RIGHT=\"ots_adeies_leave_balance.leave_category_id\" )WHERE(    EXP1 =\"ots_adeies_leave_balance.employee_id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndModifiedColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_New_Employee_Balance
    {
        [Key]
        [DwColumn("ots_adeies_leave_balance", "id")]
        public decimal Ots_Adeies_Leave_Balance_Id { get; set; }

        [DwColumn("ots_adeies_leave_balance", "employee_id")]
        public decimal? Ots_Adeies_Leave_Balance_Employee_Id { get; set; }

        [StringLength(20)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_leave_category", "title")]
        public string Ots_Adeies_Leave_Category_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_leave_category", "default_balance")]
        public decimal? Ots_Adeies_Leave_Category_Default_Balance { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_leave_category", "is_default")]
        public byte? Ots_Adeies_Leave_Category_Is_Default { get; set; }

        [DwColumn("ots_adeies_leave_balance", "days")]
        public decimal? Ots_Adeies_Leave_Balance_Days { get; set; }

        [DwColumn("ots_adeies_leave_balance", "days_taken")]
        public decimal? Ots_Adeies_Leave_Balance_Days_Taken { get; set; }

        [DwColumn("ots_adeies_leave_balance", "leave_category_id")]
        public decimal? Ots_Adeies_Leave_Balance_Leave_Category_Id { get; set; }

    }

}



