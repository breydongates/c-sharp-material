using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SallyServer.DAO;
using SallyServer.Models;

namespace SallyServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsDao questionsDao;

        public QuestionsController(IQuestionsDao questionsDao)
        {
            this.questionsDao = questionsDao;
        }

        [HttpGet]
        public ActionResult<List<Question>> GetAllQuestions()
        {
            return Ok(this.questionsDao.GetQuestions());
        }

        [HttpGet("{id}")]
        public ActionResult<Question> GetQuestion(int id)
        {
            Question question = this.questionsDao.GetQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(question);
        }

        [HttpPut("{id}")]
        public ActionResult<List<Question>> UpdateQuestion(int id, Question newQuestion)
        {
            Question question = this.questionsDao.GetQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            return Ok(this.questionsDao.UpdateQuestion(newQuestion));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteQuestion(int id)
        {
            Question question = this.questionsDao.GetQuestion(id);

            if (question == null)
            {
                return NotFound();
            }

            this.questionsDao.Delete(id);

            return NoContent();
        }

        [HttpGet("random")]
        public ActionResult<Question> GetRandomQuestion()
        {
            Question question = this.questionsDao.GetRandomQuestion();
            if (question == null)
            {
                return NoContent();
            }

            return Ok(question);
        }

        [HttpPost]
        public ActionResult<Question> AddQuestion(Question question)
        {
            Question newQuestion = this.questionsDao.AddQuestion(question);

            return Created($"/questions/{newQuestion.Id}", newQuestion);
        }
    }
}
