using Chinook.Framework.DAL;
using Chinook.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Chinook.Framework.BLL
{
    [DataObject]
    public class AdminCRUD
    {
        #region CRUD methods for Tracks

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Track> ListAllTracks()
        {
            using (var context = new ChinookContext())
            {
                return context.Tracks
                                .Include(x => x.Album)
                                .Include(x => x.MediaType)
                                .Include(x => x.Genre)
                                .ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddTrack(Track info)
        {
            using (var context = new ChinookContext())
            {
                // Note: might want to do other business process validation here
                context.Tracks.Add(info);
                context.SaveChanges(); // will trigger entity's validation attributes
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTrack(Track info)
        {
            using (var context = new ChinookContext())
            {
                var existing = context.Entry(info);
                existing.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteTrack(Track info)
        {
            using (var context = new ChinookContext())
            {
                var existing = context.Tracks.Find(info.TrackId);
                context.Tracks.Remove(existing);
                context.SaveChanges();
            }
        }


        #endregion

    }
}
