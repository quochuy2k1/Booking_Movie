namespace Booking_Movie.Utilities.Common
{
    public class ParseHelper<T> where T : class
    {
        //    public static IEnumerable<DXFilter> ParseFilters(object[] filterArray)
        //    {
        //        try
        //        {
        //            if (filterArray == null)
        //                return Enumerable.Empty<DXFilter>();
        //            else
        //            {
        //                var flattenArray = FlattenArray(filterArray);
        //                var result = new List<string[]>();
        //                List<string> list = new List<string>();

        //                for (int i = 0; i < flattenArray.Count(); i++)
        //                {
        //                    if (i % 3 == 0 && i != 0)
        //                    {
        //                        result.Add(list.ToArray());
        //                        list.Clear();

        //                    }
        //                    list.Add(flattenArray.ElementAt(i)[0]);

        //                }
        //                return result.Select(f =>
        //                new DXFilter() { Field = f[0], Comparator = ParseComparator(f[1]), Value = f[2] });
        //                //return flattenArray.Select(f =>
        //                //{
        //                //    return new DXFilter() { Field = f[0], Comparator = ParseComparator(f[1]), Value = f[2] };
        //                //});

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }

        //    }

        //    private static IEnumerable<string[]> FlattenArray(object[] filters)
        //    {
        //        //foreach (var filter in filters.Where(f => f.GetType() == typeof(object[])).Cast<object[]>()) //we drop all "and"s
        //        //{
        //        //    if (filter.All(f => f.GetType() != typeof(object[])))
        //        //        yield return filter.Select(o => o.ToString()).ToArray();
        //        //    else
        //        //        foreach (var subFilter in FlattenArray(filter))
        //        //            yield return subFilter;
        //        //}
        //        //var flattenedFilters = new List<string[]>();

        //        //foreach (var filter in filters.Where(x => x.GetType() != typeof(object[])))
        //        //{
        //        //    if (filter is string[] subFilterArray)
        //        //    {
        //        //        var subFilters = FlattenArray(subFilterArray);
        //        //        flattenedFilters.AddRange(subFilters);
        //        //    }
        //        //    else
        //        //    {
        //        //        flattenedFilters.Add(new[] { filter.ToString() });
        //        //    }
        //        //}

        //        //return flattenedFilters;

        //        foreach (var filter in filters)
        //        {
        //            if (filter is object[] subFilterArray)
        //            {
        //                foreach (var subFilter in FlattenArray(subFilterArray))
        //                {
        //                    yield return subFilter;
        //                }
        //            }
        //            else
        //            {
        //                yield return new string[] { filter.ToString() };
        //            }
        //        }

        //    }

        //    private static DXFilter.DXFilterComparator? ParseComparator(string pComparator)
        //    {
        //        return pComparator switch
        //        {
        //            "=" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.Equals,
        //            "contains" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.Contains,
        //            ">" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.GreaterThan,
        //            ">=" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.GreaterThanOrEqual,
        //            "<" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.LessThan,
        //            "<=" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.LessThanOrEqual,
        //            "!=" => (DXFilter.DXFilterComparator?)DXFilter.DXFilterComparator.NotEquals,
        //            _ => null,
        //        };
        //    }

        //    public static DXFilterExpression CreateExpression(object[] data, ref int index)
        //    {
        //        if (index >= data.Length)
        //            return null;

        //        DXFilterExpression expression = new DXFilterExpression();

        //        if (data[index] is Newtonsoft.Json.Linq.JArray conditionData)
        //        {
        //            var conditionArray = conditionData.ToObject<string[]>();
        //            expression.Condition = new DXFilter
        //            {
        //                Field = conditionArray[0],
        //                Comparator = ParseComparator(conditionArray[1]),
        //                Value = conditionArray[2]
        //            };
        //            index++;
        //        }

        //        if (index < data.Length && data[index] is string logicalOperator)
        //        {
        //            expression.Operator = logicalOperator;
        //            index++;

        //            expression.LeftFilterExpression = CreateExpression(data, ref index);

        //            if (index < data.Length && data[index] is string nextLogicalOperator && nextLogicalOperator != logicalOperator)
        //            {
        //                index++;
        //                expression.RightFilterExpression = CreateExpression(data, ref index);
        //            }
        //        }

        //        return expression;
        //    }

        //    public static Expression<Func<T, bool>>? BuildPredicate(DXFilterExpression? conditionExpression)
        //    {
        //        if (conditionExpression == null)
        //            return null;

        //        Expression<Func<T, bool>>? leftPredicate = BuildPredicate(conditionExpression.LeftFilterExpression);
        //        Expression<Func<T, bool>>? rightPredicate = BuildPredicate(conditionExpression.RightFilterExpression);

        //        if (conditionExpression.Operator == "and")
        //        {
        //            if (leftPredicate != null && rightPredicate != null)
        //                return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(leftPredicate.Body, rightPredicate.Body), leftPredicate.Parameters);
        //            else if (leftPredicate != null)
        //                return leftPredicate;
        //            else if (rightPredicate != null)
        //                return rightPredicate;
        //        }
        //        else if (conditionExpression.Operator == "or")
        //        {
        //            if (leftPredicate != null && rightPredicate != null)
        //                return Expression.Lambda<Func<T, bool>>(Expression.OrElse(leftPredicate.Body, rightPredicate.Body), leftPredicate.Parameters);
        //            else if (leftPredicate != null)
        //                return leftPredicate;
        //            else if (rightPredicate != null)
        //                return rightPredicate;
        //        }
        //        else if (conditionExpression.Condition != null)
        //        {
        //            var parameter = Expression.Parameter(typeof(T), "entity");
        //            var property = Expression.Property(parameter, conditionExpression.Condition.Field!);
        //            var constant = Expression.Constant(conditionExpression.Condition.Value);
        //            Expression condition;

        //            if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.Equals)
        //            {
        //                condition = Expression.Equal(property, constant);
        //            }
        //            else if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.NotEquals)
        //            {
        //                condition = Expression.NotEqual(property, constant);
        //            }
        //            else if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.Contains)
        //            {
        //                var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
        //                condition = Expression.Call(property, containsMethod!, constant);
        //            }
        //            else if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.GreaterThan)
        //            {
        //                condition = Expression.GreaterThan(property, constant);
        //            }
        //            else if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.GreaterThanOrEqual)
        //            {
        //                condition = Expression.GreaterThanOrEqual(property, constant);
        //            }
        //            else if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.LessThan)
        //            {
        //                condition = Expression.LessThan(property, constant);
        //            }
        //            else if (conditionExpression.Condition.Comparator == DXFilter.DXFilterComparator.LessThanOrEqual)
        //            {
        //                condition = Expression.LessThanOrEqual(property, constant);
        //            }
        //            else
        //            {
        //                throw new InvalidOperationException("Invalid operator.");
        //            }

        //            var predicate =  Expression.Lambda<Func<T, bool>>(condition, parameter);
        //            return predicate;
        //        }

        //        return null;
        //    }
    }
}