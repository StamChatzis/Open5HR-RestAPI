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
    [DataWindow("dw_employee_sv_grid", DwStyle.Grid)]
    [Table("ots_adeies_employee")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_user\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_user.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee.id\" ))")]
    #endregion
    [DwSort("ots_adeies_user_is_enabled D ots_adeies_employee_issupervisor D")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndModifiedColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_Employee_Sv_Grid
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_user", "employee_id")]
        public decimal? Ots_Adeies_User_Employee_Id { get; set; }

        [StringLength(20)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_employee", "first_name")]
        public string Ots_Adeies_Employee_First_Name { get; set; }

        [StringLength(20)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_employee", "last_name")]
        public string Ots_Adeies_Employee_Last_Name { get; set; }

        [StringLength(20)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_user", "username")]
        public string Ots_Adeies_User_Username { get; set; }

        [DwColumn("ots_adeies_employee", "isSupervisor")]
        public int? Ots_Adeies_Employee_Issupervisor { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_user", "id")]
        public decimal Ots_Adeies_User_Id { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_employee", "id")]
        public decimal Ots_Adeies_Employee_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ots_adeies_user", "is_enabled")]
        public byte? Ots_Adeies_User_Is_Enabled { get; set; }

    }

}



