select * from categories;

select distinct a.name, Concat_ws(' > ', c.name, b.name, a.name) from categories a
join categories b on a.parent_category_id = coalesce(b.category_id)
join categories c on b.parent_category_id = coalesce(c.category_id)