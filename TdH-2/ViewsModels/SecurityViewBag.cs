using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Web;
using PagedList;
using TdH_2.Models;

namespace TdH_2.ViewsModels
{
    public class SecurityViewBag
    {
        private IPagedList<securities> _pagination;
        private Dictionary<String, String> _likeSearch;
        private Dictionary<String, String> _sorts;
        private List<securities> _securities;
        private bool _islikeSearch;

        public SecurityViewBag()
        {
            _likeSearch = new Dictionary<string, string>();
            _sorts = new Dictionary<string, string>();
            initSort();
            initLikeSearch();
        }

        public IPagedList<securities> Pagination
        {
            get { return _pagination; }
            set { _pagination = value; }
        }

        public List<securities> Security
        {
            get { return _securities; }
            set { _securities = value; }
        }

        public Dictionary<String, String> LikeSearch
        {
            get { return _likeSearch; }
            set
            {
                // Trick for save search value by the user
                _islikeSearch = true;
                _likeSearch = value;
            }
        }

        public bool IslikeSearch
        {
            get { return _islikeSearch; }
            set { _islikeSearch = value; }
        }

        public void inverseSortOrder(string sortOrder)
        {
            string[] work = sortOrder.Split('-');
            string order = "desc";

            if (work[1] == "desc")
            {
                order = "asc";
            }

            _sorts[work[0]] = work[0] + "-" + order;
        }

        public string SortParams(string name)
        {
            return _sorts[name];
        }

        private void initLikeSearch()
        {
            _likeSearch["lieu_incident"] = "";
            _likeSearch["zone"] = "";
            _likeSearch["pays"] = "";
            _likeSearch["gravite_incident"] = "";
            _likeSearch["responsabilite_tdh"] = "";
            _likeSearch["resume_incident"] = "";
        }

        public void initSort()
        {
            _sorts["zone"] = "zone-asc";
            _sorts["pays"] = "pays-asc";
            _sorts["gravite_incident"] = "gravite_incident-asc";
            _sorts["responsabilite_tdh"] = "responsabilite_tdh-asc";
        }
    }
}