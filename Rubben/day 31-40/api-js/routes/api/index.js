"use strict";

module.exports = async function (fastify, opts) {
  fastify.get("/hello/:name", async function (request, reply) {
    const { name } = request.params;
    reply.send({ message: `Hello ${name}` });
  });
};
