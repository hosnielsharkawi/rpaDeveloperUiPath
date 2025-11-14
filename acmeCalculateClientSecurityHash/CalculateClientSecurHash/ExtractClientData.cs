using acmeCalculateClientSecurityHash.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace acmeCalculateClientSecurityHash
{
    public class ExtractClientData : CodedWorkflow
    {
        [Workflow]
        public (string ClientID, string ClientName, string ClientCountry, string SecurityHash) Execute(string clientInfoText)
        {
           
            var idMatch = Regex.Match(clientInfoText, @"Client ID:\s*([^\r\n]+)");
            var nameMatch = Regex.Match(clientInfoText, @"Client Name:\s*([^\r\n]+)");
            var countryMatch = Regex.Match(clientInfoText, @"Client Country:\s*([^\r\n]+)");

            string id = idMatch.Success ? idMatch.Groups[1].Value.Trim() : "";
            string name = nameMatch.Success ? nameMatch.Groups[1].Value.Trim() : "";
            string country = countryMatch.Success ? countryMatch.Groups[1].Value.Trim() : "";
            
            string combined = id +"-"+ name +"-"+country;
            string hash = ComputeHash(combined);

            return (id, name, country,hash );
        }
        
        private string ComputeHash(string input)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        
        
        
    }
}