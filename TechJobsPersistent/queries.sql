--Part 1
-- show columns from jobs;
-- select * from jobs
--Id (int)
--Name (varchar)
--EmployerId (int)

--Part 2
--select name
--from employers
--where location = "St. Louis City"

--Part 3
--select skills.name, skills.description
--from skills
--left outer join jobskills on skills.id = jobskills.SkillId
--where jobskills.JobId is not null
--order by skills.name ASC;
