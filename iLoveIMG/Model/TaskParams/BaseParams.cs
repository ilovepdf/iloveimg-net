using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLoveIMG.Model.TaskParams
{
    /// <summary>
    ///     Base Params
    /// </summary>
    public abstract class BaseParams
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected BaseParams()
        {
            setDefaultProps();
        }

        /// <summary>
        /// Ignore Errors
        /// </summary>
        [JsonProperty("ignore_errors")]
        public Boolean IgnoreErrors { get; set; }

        /// <summary>
        /// Ignore Password
        /// </summary>
        [JsonProperty("ignore_password")]
        public Boolean IgnorePassword { get; set; }

        /// <summary>
        /// {date}=current date, {n}=file number, {filename}=original filename, {tool}=the current processing action. Example:
        /// file_{n}_{date}
        /// </summary>
        [JsonProperty("output_filename")]
        public String OutputFileName { get; set; }

        /// <summary>
        ///     If output files are more than one will be served compressed. Specify the filename of the compressed file.
        ///     {date}=current date, {n}=file number,{filename}=original filename, {app}=the current processing action. Example:
        ///     zipped_{n}_{date}
        ///     Default filename: output.zip
        /// </summary>
        [JsonProperty("packaged_filename")]
        public String PackageFileName { get; set; }

        /// <summary>
        ///     If specified it is assumed all previously uploaded files for the task has been uploaded encrypted. The key will be
        ///     used to decrypt the files before processing and re-encrypt them after processing. Only keys of sizes 16, 24 or 32
        ///     are supported.
        ///     Default: null
        /// </summary>
        [JsonProperty("file_encryption_key")]
        public String FileEncryptionKey { get; set; }

        /// <summary>
        ///     When a IMG to process fails we try to repair it automatically.
        /// </summary>
        [JsonProperty("try_image_repair")]
        public Boolean TryImgRepair { get; set; }

        /// <summary>
        ///     When a IMG to process fails we try to repair it automatically.
        /// </summary>
        [JsonProperty("custom_int ")]
        public int CustomInt { get; set; }

        /// <summary>
        ///     Use this parameter to store integers as you wish. You can use it to filter your tasks in the GET /task resource
        /// </summary>
        [JsonProperty("custom_string")]
        public String CustomString { get; set; }

        /// <summary>
        ///     Callback URL. If you don't want to maintain the connection open until the task processing is finished, send webhook equal and a valid URL. 
        ///     The API will close the connection immediately and will POST all the /task resource information to the URL provided. 
        ///     Optionally this parameter can be equal to empty string. When is equal to empty string, the behaviour will be the same but no callback will be sent, 
        ///     this is useful if you don't want to wait the process to end or receive callbacks giving you the freedom of send periodic GET calls to /task/{task} to know the status of that task and if it has been completed.
        /// </summary>
        [JsonProperty("webhook ")]
        public String WebHook { get; set; }

        private void setDefaultProps()
        {
            TryImgRepair = true;
            IgnoreErrors = true;
        }
    }

    /// <summary>
    /// Office To img Params
    /// </summary>
    public class OfficeToImgParams : BaseParams
    {
    }

    /// <summary>
    ///     Rotate Params
    /// </summary>
    public class RotateParams : BaseParams
    {
    }

    /// <summary>
    ///     Repair Params
    /// </summary>
    public class RepairParams : BaseParams
    {
    }

    /// <summary>
    ///     Unlock Params
    /// </summary>
    public class UnlockParams : BaseParams
    {
    }

    /// <summary>
    ///     Remove background Params
    /// </summary>
    public class RemoveBackgroundParams : BaseParams
    {
    }
}
