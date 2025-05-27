using Microsoft.Extensions.Logging;
using Restaurant.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickify.Database.Dtos;
using Restaurant.Database.Dtos;
using Restaurant.Database.Entities;

namespace Restaurant.Database.QueryExtensions
{
    public static class OrdersQueryExtension
    {
        public static IQueryable<Order> FilterByOrderStartDate(this IQueryable<Order> query, DateRangeDto dateRange)
        {
            if (dateRange == null)
                return query;

            return query
                .Where(e => e.OrderDate >= dateRange.StartDate)
            .Where(e => e.OrderDate <= dateRange.EndDate);
        }

        public static IQueryable<Order> SearchBy(this IQueryable<Order> query, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
                return query;
            return query
            .Where(e => e.Meal.Contains(searchValue));
        }

        public static IQueryable<Order> SortBy(this IQueryable<Order> query, OrderSortingDto sortingOption)
        {
            if (sortingOption == null)
                return query;

            if (sortingOption.Criterion == OrdersSortingCriteria.MealName)
            {
                if (sortingOption.Order == SortingOrder.Ascending)
                    return query.OrderBy(e => e.Meal);
                else if (sortingOption.Order == SortingOrder.Descending)
                    return query.OrderByDescending(e => e.Meal);
            }
            else if (sortingOption.Criterion == OrdersSortingCriteria.EventStartDate)
            {
                if (sortingOption.Order == SortingOrder.Ascending)
                    return query.OrderBy(e => e.OrderDate);
                else if (sortingOption.Order == SortingOrder.Descending)
                    return query.OrderByDescending(e => e.OrderDate);
            }

            return query;
        }
    }
}
