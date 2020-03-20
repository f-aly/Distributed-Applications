using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class TranscriptProcessor
    {
        public static int CreateTranscript(int transcriptId, DateTime transcriptDate, bool transcriptStatus)
        {

            TranscriptModel data = new TranscriptModel {
                TranscriptId = transcriptId,
                TranscriptDate = transcriptDate,
                TranscriptStatus = transcriptStatus
            };

            string sql = @"insert into dbo.Transcript (TranscriptId, TranscriptDate, TranscriptStatus)
                            values (@TranscriptId, @TranscriptDate, @TranscriptStatus);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<TranscriptModel> LoadTranscripts()
        {
            string sql = @"select Id, TranscriptId, TranscriptDate, TranscriptStatus
                            from dbo.Transcript;";
            return SqlDataAccess.LoadData<TranscriptModel>(sql);
        }
    }
}
