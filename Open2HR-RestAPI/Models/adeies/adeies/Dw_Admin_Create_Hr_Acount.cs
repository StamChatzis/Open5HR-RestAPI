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
    [DataWindow("dw_admin_create_hr_acount", DwStyle.Default)]
    [Table("ots_adeies_user")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_user\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [DwTemplate(DataFormat.Xml, "1", "adeies\\adeies\\dw_admin_create_hr_acount.tpl.1.xml")]
    public class Dw_Admin_Create_Hr_Acount
    {
        [Key]
        [DwColumn("ots_adeies_user", "id")]
        public decimal Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("ots_adeies_user", "username")]
        public string Username { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_user", "password")]
        public string Password { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_user", "is_enabled")]
        public byte? Is_Enabled { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_user", "role")]
        public string Role { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ots_adeies_user", "employee_id")]
        public decimal? Employee_Id { get; set; }

    }

}



