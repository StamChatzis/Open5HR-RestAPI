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
    [DataWindow("dw_auth", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_user\" )  TABLE(NAME=\"ots_adeies_employee\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_user.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee.id\" )WHERE(    EXP1 =\"ots_adeies_user.username\"   OP =\"=\"    EXP2 =\":as_username\"    LOGIC =\"And\" ) WHERE(    EXP1 =\"ots_adeies_user.password\"   OP =\"=\"    EXP2 =\":as_password\" ) ) ARG(NAME = \"as_username\" TYPE = string)  ARG(NAME = \"as_password\" TYPE = string)")]
    #endregion
    [DwParameter("as_username", typeof(string))]
    [DwParameter("as_password", typeof(string))]
    public class Dw_Auth
    {
        [StringLength(20)]
        [DwColumn("ots_adeies_user", "password")]
        public string Password { get; set; }

        [StringLength(20)]
        [DwColumn("ots_adeies_user", "username")]
        public string Username { get; set; }

        [DwColumn("ots_adeies_user", "id")]
        public decimal Id { get; set; }

        [DwColumn("ots_adeies_employee", "id")]
        public decimal Ots_Adeies_Employee_Id { get; set; }

        [DwColumn("ots_adeies_user", "is_enabled")]
        public byte? Ots_Adeies_User_Is_Enabled { get; set; }

    }

}



