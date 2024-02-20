("use strict");
const { PrismaClient } = require("@prisma/client");
const prisma = new PrismaClient();
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
async function routes(fastify, opts) {
  fastify.get("/hello/:name", async function (request, reply) {
    const { name } = request.params;
    reply.send({ message: `Hello ${name}` });
  });

  fastify.post("/sup/", { schema }, async (request, reply) => {
    return { name: "world" };
  });

  fastify.get("/user/:name", async (request, reply) => {
    const { nama } = request.params;
    const user = await prisma.user.findFirst({
      where: {
        name: nama,
      },
    });
    reply.send(user);
  });

  fastify.post("/adduser", async (request, reply) => {
    const { email, name } = request.body;
    const user = await prisma.user.create({
      data: {
        email,
        name
      },
    });
    reply.send(user)
  });
}
module.exports = routes;
