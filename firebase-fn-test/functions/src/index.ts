import { onCall } from "firebase-functions/v2/https";
import * as logger from "firebase-functions/logger";

export const hello = onCall((request) => {
  logger.info("hello called", { data: request.data });
  return { message: "Hello from Callable!", time: Date.now() };
});