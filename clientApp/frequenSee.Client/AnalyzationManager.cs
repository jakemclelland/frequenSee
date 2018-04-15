using frequenSee.Engine;
using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenSee.Client
{
    public class AnalyzationManager
    {
        public AnalyzationResponse RunAnalisis(AnalyzationRequest request)
        {
            AnalyzationResponse response = new AnalyzationResponse();

            if (!string.IsNullOrEmpty(request.InputFilePath))
            {
                if (!File.Exists(request.InputFilePath))
                {
                    throw new FileNotFoundException("File not found", request.InputFilePath);
                }

                request.InputText = File.ReadAllText(request.InputFilePath);
            }

            response.ResultSet = InputDigester.DigestInput(request.InputText, request.AnalyzationType);
        
            return response;
        }
    }
}
