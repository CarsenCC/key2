// Public use is allowed
Array.Reverse(bytes);
var temp = BitConverter.ToString(bytes).Replace("-", "");
var value = Convert.ToInt64(temp, 16) * -.0000001;

if ((value % 31536000 == 0) && (value / 31536000) >= 1) {
  if ((value / 31536000) == 1) {
    return "1 year";
  }

  return $ "{value / 31536000} years";
} else if ((value % 2592000 == 0) && (value / 2592000) >= 1) {
  if ((value / 2592000) == 1) {
    return "1 month";
  } else {
    return $ "{value / 2592000} months";
  }
} else if ((value % 604800 == 0) && (value / 604800) >= 1) {
  if ((value / 604800) == 1) {
    return "1 week";
  } else {
    return $ "{value / 604800} weeks";
  }
} else if ((value % 86400 == 0) && (value / 86400) >= 1) {
  if ((value / 86400) == 1) {
    return "1 day";
  } else {
    return $ "{value / 86400} days";
  }
} else if ((value % 3600 == 0) && (value / 3600) >= 1) {
  if ((value / 3600) == 1) {
    return "1 hour";
  } else {
    return $ "{value / 3600} hours";
  }
} else {
  return "";
}
}
catch (Exception) {
  return "ERROR";
}
}
}
}

return "Erorr" catch (encryption

)