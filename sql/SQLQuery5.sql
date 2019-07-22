SELECT tr.Nome as 'Turma',

a.Aluno

FROM Turma tr 

inner join TurmaAlunos ta on tr.Id = ta.Turma
inner join Alunos a on ta.Aluno = a.Id;

SELECT 
            d.[Data],
			tr.Aluno,
            n.Nota as 'Média',
			IIF(ISNULL(p.Id,0) >0, 'Presente', 'Ausente') as 'Presenças'
FROM Diario d 
             inner join TurmaAlunos tr on d.Turma = tr.Turma 
             --inner join Turma t on tr.Turma = t.Id
             --inner join Alunos a on tr.Aluno = a.Id
			 left join Presenca p on d.Id = p.Diario and tr.Aluno = p.Diario
             left join Nota n on tr.Aluno = n.Aluno and d.Id = n.Diario
group by d.[Data], tr.Aluno, n.Nota
