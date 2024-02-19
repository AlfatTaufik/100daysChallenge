"use strict";
let testschema = {
  type: "object",
  properties: {
    name: { type: "string" },
  },
  required: ["name"],
};
const schema = {
  body: testschema,
};
module.exports = async function (fastify, opts) {
  fastify.get("/hello/:name", async function (request, reply) {
    const { name } = request.params;
    reply.send({ message: `Hello ${name}` });
  });

  fastify.post("/sup/", { schema }, async (request, reply) => {
    return { name: "world" };
  });

  fastify.get("/user/:name", async (request, reply) => {
    
  });
};
