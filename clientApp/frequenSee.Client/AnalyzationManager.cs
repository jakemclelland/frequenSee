using frequenSee.Engine;
using frequenSee.Models;
using System;
using System.Collections.Generic;
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

            response.ResultSet = InputDigester.DigestInput(request.InputText, request.AnalyzationType);
        
            return response;
        }
    }
}
