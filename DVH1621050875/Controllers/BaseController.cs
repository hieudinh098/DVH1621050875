using DVH1621050875.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DVH1621050875.Controllers
{
    public class BaseController : Controller
    {
        protected const string PERSON_PREFIX = "PER";
        protected const string STUDENT_PREFIX = "STD";
        protected const string LECTURE_PREFIX = "LCT";
        protected DVH1621050875Db db = new DVH1621050875Db();

        protected string GetId(string _prefix)
		{
            switch (_prefix)
			{
                case PERSON_PREFIX:
					{
                        var maxId = db.People.Max(p => p.PersonId);
                        return FormatId(PERSON_PREFIX, maxId);
                    }
                case STUDENT_PREFIX:
                    {
                        var maxId = db.Students.Max(p => p.PersonId);
                        return FormatId(STUDENT_PREFIX, maxId);
                    }
                case LECTURE_PREFIX:
                    {
                        var maxId = db.Lectures.Max(p => p.PersonId);
                        return FormatId(LECTURE_PREFIX, maxId);
                    }
				default:
					{
                        throw new Exception("Invalid prefix");
					}
            }
		}
        private string FormatId(string _prefix, string maxId)
		{
            if (String.IsNullOrEmpty(maxId))
            {
                maxId = "0";
            }
            var maxNum = Convert.ToInt32(maxId.Replace(_prefix, ""));
            maxNum++;
            return String.Format("{0}{1:D4}", _prefix, maxNum);
        }
    }
}