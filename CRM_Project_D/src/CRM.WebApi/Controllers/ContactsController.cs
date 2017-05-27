﻿namespace CRM.WebApi.Controllers
{
    using System;
    using System.Web.Http;
    using System.Threading.Tasks;
    using Models;
    using Entities;
    using InfrastructureModel;
    public class ContactsController : ApiController
    {
        private readonly ApplicationManager _manager = new ApplicationManager();
        public async Task<IHttpActionResult> GetAllContactsAsync()
        {
            // TODO: login/auth check with token
            try
            {
                var data = await _manager.GetAllContactsAsync();
                if (ReferenceEquals(data, null)) return NotFound();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IHttpActionResult> GetContactByIdAsync(int? id)
        {
            // TODO: login/auth check with token
            if (!id.HasValue) return BadRequest("Set parameter.");
            try
            {
                var contact = await _manager.GetContactByIdAsync(id);
                if (ReferenceEquals(contact, null)) return NotFound();
                return Ok(contact);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IHttpActionResult> GetContactByGuidAsync([FromUri] Guid? guid)
        {
            try
            {
                var contact = await _manager.GetContactByGuidAsync(guid);
                if (ReferenceEquals(contact, null)) return NotFound();
                return Ok(contact);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //public async Task<IHttpActionResult> GetContactByPaginationAsync(int start, int numberOfRows, bool ascending)
        //{
        //    using (var database = new CRMContext())
        //    {
        //        try
        //        {
        //            var contacts = ascending
        //                            ? database.Contacts.OrderBy(x => x.ContactId)
        //                                .Skip(start - 1)
        //                                .Take(numberOfRows)
        //                            : database.Contacts.OrderByDescending(x => x.ContactId)
        //                                .Skip(start - 1)
        //                                .Take(numberOfRows);
        //            var result = ViewContact.GetContactModelList(await contacts.ToListAsync());
        //            if (ReferenceEquals(result, null)) return NotFound();
        //            return Ok(result);
        //        }
        //        catch (Exception ex)
        //        {
        //            return BadRequest(ex.Message);
        //        }
        //    }
        //}

        // working

        // working
        public async Task<IHttpActionResult> PutContactAsync([FromBody] ViewContact c)
        {
            // TODO: login/auth check with token
            if (ReferenceEquals(c, null) || !ModelState.IsValid) return BadRequest();
            try
            {
                if (await _manager.UpdateConactAsync(c)) return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        public async Task<IHttpActionResult> PostContactAsync([FromBody] ViewContact c)
        {
            // TODO: login/auth check with token
            if (ReferenceEquals(c, null) || !ModelState.IsValid) return BadRequest();
            try
            {
                if (await _manager.AddContactAsync(c)) return Ok();
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public async Task<IHttpActionResult> DeleteContactByGuIdAsync(Guid? guid)
        {
            // TODO: login/auth check with token
            if (!guid.HasValue) return BadRequest();
            try
            {
                if (await _manager.DeleteContactAsync(guid.Value)) return Ok();
                return BadRequest();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("api/contacts/upload")]
        public async Task<IHttpActionResult> PostContactByteArrayAsync([FromBody] byte[] array)
        {
            string pathtowork = ""; // path to work with file, on the end of function it will be deleted.
            using (var database = new CRMContext())
            using (var transaction = database.Database.BeginTransaction())
            {
                try
                {
                    var contacts = ParserProvider.GetContactsFromFile(array, pathtowork);
                    {
                        database.Contacts.AddRange(contacts);
                        await database.SaveChangesAsync();
                        transaction.Commit();
                        return Ok();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return BadRequest(ex.Message);
                }
            }
        }
        [Route("api/contacts/count")]
        public async Task<int> GetContactsPageCount()
        {
            return await _manager.PageCountAsync();
        }
    }
}
