using AdminApi.DTO.App.StoreMasterDTO;
using AdminApi.Models.App.StoreMaster;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App.Agent;
using AdminApi.DTO.App.AgentDTO;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.App.Location;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Security.Cryptography;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Agent> _AgentRepo;
        public AgentController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Agent> AgentRepo)

        {
            _config = config;
            _context = context;
            _AgentRepo = AgentRepo;

        }

        [AllowAnonymous]
        [HttpGet("{AgentuserId}/{PassWord}")]
        public ActionResult AgentLogin(string AgentuserId, string PassWord)
        {

            try
            {
                string encryptedPassword = EncryptPassword(PassWord);
                var list = (from u in _context.Agents
                            select new
                            {
                                u.AgentId,
                                u.AgentName,
                                u.AgentPhoneNumber,
                                u.Address,
                                u.PinCode,
                                u.ProfilePhoto,
                                u.AgentuserId,
                                u.PassWord,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.AgentuserId == AgentuserId && x.PassWord == encryptedPassword).FirstOrDefault();

                if (list != null)
                {
                    return Ok(list);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        public static string EncryptPassword(string password)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("x2"));
            }
            return result.ToString();
        }

        [HttpPost]
        public IActionResult AgentCreate(AgentCreateDTO AgentCreateDTO)
        {
            var objcheck = _context.Agents.SingleOrDefault(opt => opt.AgentuserId == AgentCreateDTO.AgentuserId && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Agent Agent = new Agent();
                    Agent.AgentName = AgentCreateDTO.AgentName;
                    Agent.AgentPhoneNumber = AgentCreateDTO.AgentPhoneNumber;
                    Agent.Address = AgentCreateDTO.Address;
                    Agent.PinCode = AgentCreateDTO.PinCode;
                    Agent.ProfilePhoto = AgentCreateDTO.ProfilePhoto;
                    Agent.AgentuserId = AgentCreateDTO.AgentuserId;
                    Agent.PassWord = EncryptPassword(AgentCreateDTO.PassWord);
                    Agent.CreatedBy = AgentCreateDTO.CreatedBy;
                    Agent.CreatedOn = System.DateTime.Now;
                    var obj = _AgentRepo.Insert(Agent);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate User Id..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpGet]
        public ActionResult GetAgentList()
        {
            try
            {
                var list = (from u in _context.Agents
                            join a in _context.Users on u.CreatedBy equals a.UserId


                            select new { u.AgentId, u.AgentName, u.AgentPhoneNumber, u.Address, u.PinCode, u.ProfilePhoto, u.AgentuserId, u.PassWord, a.UserId, a.UserName, u.CreatedBy, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{UserId}")]
        public ActionResult GetAgentListbyuserid(int UserId)
        {
            try
            {
                var list = (from u in _context.Agents
                            join a in _context.Users on u.CreatedBy equals a.UserId


                            select new { u.AgentId, u.AgentName, u.AgentPhoneNumber, u.Address, u.PinCode, u.ProfilePhoto, u.AgentuserId, u.PassWord, a.UserId, a.FullName, u.CreatedBy, 
                                u.IsDeleted }).Where(x => x.IsDeleted == false && x.UserId==UserId).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{AgentId}")]
        public ActionResult GetSingleAgent(int AgentId)
        {
            try
            {
                var singleAgent = _AgentRepo.SelectById(AgentId);
                return Ok(singleAgent);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateAgent(AgentUpdateDTO AgentUpdateDTO)
        {
            try
            {
                var objAgent = _context.Agents.SingleOrDefault(opt => opt.AgentId == AgentUpdateDTO.AgentId);
                objAgent.AgentName = AgentUpdateDTO.AgentName;
                objAgent.AgentPhoneNumber = AgentUpdateDTO.AgentPhoneNumber;
                objAgent.Address = AgentUpdateDTO.Address;
                objAgent.PinCode = AgentUpdateDTO.PinCode;
                objAgent.ProfilePhoto = AgentUpdateDTO.ProfilePhoto;
                objAgent.AgentuserId = AgentUpdateDTO.AgentuserId;
                objAgent.PassWord = EncryptPassword(AgentUpdateDTO.PassWord);
                objAgent.UpdatedBy = AgentUpdateDTO.UpdatedBy;
                objAgent.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objAgent);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteAgent(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Agents.SingleOrDefault(opt => opt.AgentId == Id);
                objabout.IsDeleted = true;
                objabout.UpdatedBy = DeletedBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
    
}
