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
    [DataWindow("dw_admin_grid_users", DwStyle.Grid)]
    [Table("ots_adeies_user")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_user\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"ots_adeies_user.employee_id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class Dw_Admin_Grid_Users
    {
        [Key]
        [DwColumn("ots_adeies_user", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_user", "username")]
        public string Username { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_user", "password")]
        public string Password { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_user", "is_enabled")]
        public byte? Is_Enabled { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_user", "role")]
        public string Role { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_user", "employee_id")]
        public decimal? Employee_Id { get; set; }

    }

}



