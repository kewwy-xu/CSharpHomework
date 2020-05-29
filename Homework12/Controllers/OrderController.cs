using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework12.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDB;

        public OrderController(OrderContext context)
        {
            orderDB = context;
        }

        [HttpGet("{orderNo}")]
        public ActionResult<Order> GetOrder(string orderNo)
        {
            var order = orderDB.Orders.FirstOrDefault(t => t.orderNo == orderNo);

            if (order == null)
            {
                return NotFound();
            }
            else
            {
                var orderItems = orderDB.OrderItems.Where(t => t.OrderId == orderNo);
                float orderSum = 0;
                foreach (var oi in orderItems)
                {
                    order.orderItems.Add(oi);
                    oi.productSum = oi.productPrice * oi.productAmount;
                    orderSum += oi.productSum;
                }
                order.orderSum = orderSum;

                return order;
            }           
        }

        // POST: api/order
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDB.Orders.Add(order);               
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT: api/order/{orderNo}
        [HttpPut("{orderNo}")]
        public ActionResult<Order> PutOrder(string orderNo, Order order)
        {
            if (orderNo != order.orderNo)
            {
                return BadRequest("orderNo cannot be modified!");
            }
            try
            {
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
                return order;
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }            
        }

        // DELETE: api/order/{orderNo}
        [HttpDelete("{orderNo}")]
        public ActionResult DeleteTodoItem(string orderNo)
        {
            try
            {
                var order = orderDB.Orders.Include("orderItems").FirstOrDefault(t => t.orderNo == orderNo);
                if (order != null)
                {
                    orderDB.Orders.Remove(order);
                    orderDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
